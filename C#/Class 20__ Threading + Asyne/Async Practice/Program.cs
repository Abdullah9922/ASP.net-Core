public class Program
{

    public static async Task<string> GetStudentNameAsync()
    {
        // je kono kaj hote pare
        await Task.Delay(2000);
        return "Asif";
    }

    public static async Task<string> GetStudentDepartmentAsync()
    {
        await Task.Delay(2000);
        return "CSEEEEEEE";
    }

    public static async Task Main(string[] args)
    {
        var result = await GetStudentNameAsync();
        //Console.WriteLine(result);

        Task<string> task1 = GetStudentNameAsync();
        Task<string> task2 = GetStudentDepartmentAsync();

        var result1 = await task1; // task1 ses hobe then baki kaj hobe
        var result2 = await task2;

        Console.WriteLine(result1);
        Console.WriteLine(result2);


        //while(!task1.IsCompleted || !task1.IsCompleted)
        //{
        //    var completedTask = await Task.WhenAny(task1, task2); 

        //    if(completedTask == task1)
        //    {
        //        var result11 = await task1; 
        //    }

        //    else if(completedTask == task2)
        //    {
        //        Console.WriteLine(await task2);
        //    }
        //}


        // akon ame karo jonne wait korbo na. jeta age asbe ame seta print kora dibo

        Task<string> completedTask = await Task.WhenAny(task1, task2);

        Console.WriteLine(await completedTask);

        if (completedTask == task1)
        {
            Console.WriteLine(await task2);  // task1 ba task2 je jaiga te use korbo sekhane await lagbe karon task1 r task2 asynconous mathord
                                             
        }
        else
        {
            Console.WriteLine(await task1);
        }
    }
}