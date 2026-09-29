public class Program
{

    public static async Task<string> OrderFoodAsync() // aeta amon akta methord jekhane amon akta kaj hossse jeta hota time lagte pare. koto time seta jani na
    {
        Console.WriteLine("Food order placed...");

        await Task.Delay(3000); // ae khane ame delay disi but ae khane hoyto kono api thake data nea lagte pare ba database thake data fatch kora lagte pare

        return "Burger";
    }

    public static async Task<string> OrderFromA_Async() // aeta amon akta methord jekhane amon akta kaj hossse jeta hota time lagte pare. koto time seta jani na
    {
        Console.WriteLine("Food order placed...");

        await Task.Delay(3000); // ae khane ame delay disi but ae khane hoyto kono api thake data nea lagte pare ba database thake data fatch kora lagte pare

        return "Pizza";
    }

    public static async Task<string> OrderFromB_Async() // aeta amon akta methord jekhane amon akta kaj hossse jeta hota time lagte pare. koto time seta jani na
    {
        Console.WriteLine("Food order placed...");

        await Task.Delay(3000); // ae khane ame delay disi but ae khane hoyto kono api thake data nea lagte pare ba database thake data fatch kora lagte pare

        return "Pizza";
    }


    public static async Task Main(string[] args)
    {
        Console.WriteLine("App started");

        var food = await OrderFoodAsync();

        Console.WriteLine($"Received: {food}");


        string food1 = await OrderFromA_Async();
        string food2 = await OrderFromB_Async();

        Task<string> task1 = OrderFromA_Async();
        Task<string> task2 = OrderFromB_Async();

        string food11 = await task1; // age task1 ses koro then samne agao
        string food22 = await task2;
        string[] foods = await Task.WhenAll(task1, task2); // age ae gula tast complite koro then samne jao to 
    }

    /*
     
     async  → "এই method asynchronous operation করতে পারে"

    await  → "এই কাজ শেষ হওয়া পর্যন্ত অপেক্ষা করো,
              কিন্তু thread অযথা block করো না"

    Task   → "একটা চলমান/হওয়ার কথা থাকা asynchronous কাজকে represent করে"  
     
     */
}