using Level_10;

public class Mainn
{
    public static void Main(string[] args)
    {
        Libray_Book_Management l = new Libray_Book_Management();

        l.Display();
        l.Restock(4);
        l.SellBook(2);
        l.Display();
    }
}
