using level_1;

public class Solution
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        s.ShowInfo();
        s.Study();

        Student s2 = new Student("Arif");
        s2.ShowInfo();
        s2.Study(2);

        Student s3 = new Student("Arif", 23);
        s3.ShowInfo();
        s3.Study("English");

        Student s4 = new Student("Arif", 23, 992);
        s4.ShowInfo();
        s4.Study(29,"English");

        //Student s5 = new Student( 23 );
        //s.ShowInfo();
        //s.Study(29, "English");
    }

}