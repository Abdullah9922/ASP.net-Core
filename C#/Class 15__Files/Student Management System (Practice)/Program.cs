
string mainFolderPath = "Data";
DirectoryInfo folder = new DirectoryInfo(mainFolderPath);
if (!folder.Exists) 
{
    folder.Create();
    Console.WriteLine("Main Folder Created.");
}

string studentFolderPath = Path.Combine(mainFolderPath, "Student");
DirectoryInfo studentFolder = new DirectoryInfo(studentFolderPath);
if (!studentFolder.Exists)
{
    studentFolder.Create();
    Console.WriteLine("Studnt Folder Created.");
}

string studentFilePath = Path.Combine(studentFolderPath, "students.text");
FileInfo file = new FileInfo(studentFilePath);
if (!file.Exists)
{
    file.Create();
    Console.WriteLine("Student file created.");
}

using (StreamWriter sw = file.CreateText())
{
    sw.WriteLine("101, Asif, CSE");
    sw.WriteLine("102, Arif, CSE");
    sw.WriteLine("103, Arik, CSE");
    //Console.WriteLine("----------------------------------------------------------------\n\n\n");
}

while (true)
{
    Console.WriteLine("===== Student Management =====");

    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Delete Student");
    Console.WriteLine("5. Update Student");
    Console.WriteLine("6. Backup Students");
    Console.WriteLine("7. Exit");

    Console.Write("Enter Choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Add Student");
            Console.WriteLine("Input Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input Department: ");
            string department = Console.ReadLine();

            using (StreamWriter sw = file.AppendText())
            {
                sw.WriteLine(id + "," + name + "," + department + "\n");
            }
            break;

        case 2:
            Console.WriteLine("View All Students");
            string[] allStudents = File.ReadAllLines(file.FullName);
            foreach (var x in allStudents)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
            break;

        case 3:
            Console.WriteLine("Search Student");
            Console.WriteLine("Input Id: ");
            string id2 = Console.ReadLine();
            string[] allStudents2 = File.ReadAllLines(file.FullName);

            bool found = false;
            foreach (var x in allStudents2)
            {
                string[] data = x.Split(',');

                string id3 = data[0];
                string name3 = data[1];
                string department3 = data[2];

                if(id3 == id2)
                {
                    Console.WriteLine("Student Found");
                    Console.WriteLine("Name: " + name3);
                    Console.WriteLine("Department: " + department3);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student Not Found");
            }
            break;

        case 4:
            Console.WriteLine("Delete Student");
            Console.WriteLine("Input Id: ");
            string id4 = Console.ReadLine();
            List<string> updateStudents = new List<string>();
            string[] allStudents4 = File.ReadAllLines(file.FullName);

            bool found4 = false;
            foreach (var x in allStudents4)
            {
                string[] data = x.Split(',');

                string id3 = data[0];
                string name3 = data[1];
                string department3 = data[2];

                if (id3 == id4)
                {
                    found4 = true;
                    continue;
                }
                updateStudents.Add(x);
            }

            if (found4)
            {
                File.WriteAllLines(studentFilePath, updateStudents);
                Console.WriteLine("Student Deleted Successfully");
            }
            break;

        case 5:
            Console.WriteLine("Update Student");
            Console.Write("Input Id: ");
            string id5 = Console.ReadLine();
            string[] allStudents5 = File.ReadAllLines(file.FullName);
            List<string> updateStudents5 = new List<string>();

            bool found5 = false;
            foreach (var x in allStudents5)
            {
                string[] data = x.Split(',');

                string id55 = data[0];
                string name5 = data[1];
                string department5 = data[2];

                if (id55 == id5)
                {
                    Console.WriteLine("New Input Id: ");
                    int new_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input Name: ");
                    string new_name = Console.ReadLine();
                    Console.WriteLine("Input Department: ");
                    string new_department = Console.ReadLine();

                    string x2 = new_id + "," + new_name + "," + new_department;
                    updateStudents5.Add(x2);
                    found5 = true;
                    continue;
                }
                else
                {
                    updateStudents5.Add(x);
                }
            }
            File.WriteAllLines(studentFilePath, updateStudents5);

            if (!found5)
            {
                Console.WriteLine("Student Not Found");
            }
            break;

        case 6:
            Console.WriteLine("Backup Students");
            string backupFolderPath = Path.Combine(mainFolderPath, "Backup");
            DirectoryInfo backupFolder = new DirectoryInfo(backupFolderPath);

            if (!backupFolder.Exists)
            {
                backupFolder.Create();
                Console.WriteLine("Backup Folder Created\n");
            }


            string copyPath = Path.Combine(backupFolderPath, "Backup_Info.text");
            FileInfo backupFile = new FileInfo(copyPath);

            if (!backupFile.Exists)
            {
                file.CopyTo(backupFile.FullName);
                Console.WriteLine("Backup file Created\n");
            }
            break;

        case 7:
            Console.WriteLine("Exit");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}
