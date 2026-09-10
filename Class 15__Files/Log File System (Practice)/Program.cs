
string mainFolderPath = "Data";
DirectoryInfo mainFolder = new DirectoryInfo(mainFolderPath);
if (!mainFolder.Exists)
{
    mainFolder.Create();
    Console.WriteLine("\nMain Data folder created.\n");
}

string studentFolderPath = Path.Combine(mainFolderPath, "Student");
DirectoryInfo studentFolder = new DirectoryInfo(studentFolderPath);
if (!studentFolder.Exists)
{
    studentFolder.Create();
    Console.WriteLine("\nStudent Folder Created.\n");
}

string logFolderPath = Path.Combine(mainFolderPath, "Logs");
DirectoryInfo logFolder = new DirectoryInfo(logFolderPath);
if (!logFolder.Exists)
{
    logFolder.Create();
    Console.WriteLine("\nLog Folder Created.\n");
}

string filePath = Path.Combine(studentFolderPath, "students.text");
FileInfo file = new FileInfo(filePath);
if (!file.Exists)
{
    file.Create();
    Console.WriteLine("\nstudents file Created.\n");
}

string logFilePath = Path.Combine(logFolderPath, "students.text");
FileInfo logFile = new FileInfo(logFilePath);
if (!logFile.Exists)
{
    logFile.Create();
    Console.WriteLine("\nstudents file Created.\n");
}

using (StreamWriter write = new StreamWriter(filePath))
{
    write.WriteLine("101, Asif, CSE");
    write.WriteLine("102, Rahim, CSE");
    write.WriteLine("103, Karim, EEE");
}

    while (true)
    {
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Search Student");
        Console.WriteLine("3. Delete Student");
        Console.WriteLine("4. Show Logs");
        Console.WriteLine("5. Exit");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Add Student");
                Console.Write("Input Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Input Name: ");
                string name = Console.ReadLine();
                Console.Write("Input Department: ");
                string department = Console.ReadLine();

                using (StreamWriter sw = file.AppendText())
                {
                    sw.WriteLine(id + ", " + name + ", " + department + "\n");
                }

                //add in log file
                using (StreamWriter sw = logFile.AppendText())
                {
                    sw.WriteLine($"{file.LastWriteTime.ToString()} | ADD | Student {id} added\n");
                }
                break;

            case 2:
                Console.WriteLine("Search Student");
                Console.Write("Input Id: ");
                string searchId = Console.ReadLine();

                string[] studentsData = File.ReadAllLines(filePath);
                bool found = true;
                foreach(var x in studentsData)
                {
                    string[] data = x.Split(',');
                    string Id = data[0];
                    string Name = data[1];
                    string Department = data[2];

                    if (searchId == Id)
                    {
                        Console.WriteLine("Student Found");
                        Console.WriteLine("Name: " + Name);
                        Console.WriteLine("Department: " + Department);

                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine("Student Not Found");
                }
                else
                {
                    //add in log file
                    using (StreamWriter sw = logFile.AppendText())
                    {
                        sw.WriteLine($"{file.LastAccessTime.ToString()} | SEARCH  | Student {searchId} added\n");
                    }
                }
            break;

            case 3:
                Console.WriteLine("Delete Student");
                Console.Write("Input Id: ");
                string deleteId = Console.ReadLine();

                string[] studentsData3 = File.ReadAllLines(filePath);
                bool found3 = true;
                List<string> updatedList = new List<string>();
            
                foreach (var x in studentsData3)
                {
                    string[] data = x.Split(',');
                    string Id = data[0];
                    string Name = data[1];
                    string Department = data[2];

                    if (deleteId == Id)
                    {
                        found = false;
                        continue;
                    }
                    else updatedList.Add(x);
                }
                File.WriteAllLines(filePath, updatedList);

                if (found3)
                {
                    Console.WriteLine("Student Not Found");
                }
                else
                {
                    //add in log file
                    using (StreamWriter sw = logFile.AppendText())
                    {
                        sw.WriteLine($"{file.LastAccessTime.ToString()} | SEARCH  | Student {deleteId} added\n");
                    }
                }
            break;

            case 4:
                Console.WriteLine("Show Logs");
                string[] logs = File.ReadAllLines(logFilePath);
                foreach(var x in logs)
                {
                    Console.WriteLine(x);
                }
            break;

            case 5:
                Console.WriteLine("Best of luck.");
                Environment.Exit(0);
            break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
