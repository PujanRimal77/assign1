using System;

class RoseBlanches
{
    static void Main()
    {
         Console.Write("How much did you receive money ($)? ");
        int total_Money = int.Parse(Console.ReadLine());

        // Calculating the allocations
        int books_Supplies = (int)(0.75 * total_Money);
        int remain_Money = total_Money - books_Supplies;
        int portionForEach = remain_Money / 3;

        // Setting up the values for coffee, flash computer and subway ticket price
        int coffeePrice = 2;
        int flashComputerPrice = 4;
        int subwayTicketPrice = 3;

        // this is the calculation for each item 
        int coffees = portionForEach / coffeePrice;
        int flashComputers = portionForEach / flashComputerPrice;
        int subwayTickets = portionForEach / subwayTicketPrice;

        // calculation of remaining money for roses
        int moneyForRoses = remain_Money - (coffees * coffeePrice + flashComputers * flashComputerPrice + subwayTickets * subwayTicketPrice);

        // Printing and diaplaying output 
        Console.WriteLine($"Book and Supplies: {books_Supplies} $");
        Console.WriteLine("You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {moneyForRoses} dollars for the white roses.");

    
}
}
