namespace _016;

internal static partial class Program
{
    private static void Main(string[] args)
    {
        var fuelType = Console.ReadLine();
        var fuelQty = double.Parse(Console.ReadLine());
        var discountCard = Console.ReadLine();

        const double gasolinePrice = 2.22;
        const double dieselPrice = 2.33;
        const double gasPrice = 0.93;

        double fuelPrice = 0;
        double discount = 0;

        switch (fuelType)
        {
            case "Gasoline":
            {
                fuelPrice = fuelQty * gasolinePrice;

                if (discountCard == "Yes") discount = fuelQty * 0.18;
                break;
            }
            case "Diesel":
            {
                fuelPrice = fuelQty * dieselPrice;

                if (discountCard == "Yes") discount = fuelQty * 0.12;
                break;
            }
            case "Gas":
            {
                fuelPrice = fuelQty * gasPrice;

                if (discountCard == "Yes") discount = fuelQty * 0.08;
                break;
            }
        }

        var totalSum = fuelPrice - discount;

        totalSum = fuelQty switch
        {
            >= 20 and <= 25 => totalSum - totalSum * 0.08,
            > 25 => totalSum - totalSum * 0.10,
            _ => totalSum
        };

        Console.WriteLine($"{totalSum:f2} lv.");
    }
}