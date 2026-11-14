namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var chickenMenus = int.Parse(Console.ReadLine());
        var fishMenus = int.Parse(Console.ReadLine());
        var veganMenus = int.Parse(Console.ReadLine());

        var menus = chickenMenus * 10.35 + fishMenus * 12.40 + veganMenus * 8.15;
        var dessert = menus * 0.20;

        Console.WriteLine(menus + dessert + 2.50);
    }
}
