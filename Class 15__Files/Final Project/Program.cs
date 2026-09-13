
using Final_Project;
using System.Diagnostics;

while (true)
{
    int input = ConsoleMenu.ShowMainMenu();

    switch (input)
    {
        case 1:
            FileOrganizer.Organize();
            break;

        case 2:
            FileSearcher.Search();

            break;

        case 3:
            FileSplitter.Split();

            break;

        case 4:
            Console.WriteLine("\nBye!\n");
            return;

        default:
            Console.WriteLine("\nInvalid choice!\n");
            break;
    }
}
