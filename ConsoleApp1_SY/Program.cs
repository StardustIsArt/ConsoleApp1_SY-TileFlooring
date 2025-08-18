namespace ConsoleApp1_SY;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user to input width, length and cost of the 1 unit of flooring.
        Console.WriteLine("Please provide the width, length and cost of one unit of flooring to calculate the entire cost of flooring needed.");
       
        // User inputs cost of one unit of flooring
        Console.Write("Enter the cost of one unit of flooring: $");
        decimal cost = decimal.Parse(Console.ReadLine());
        
        // Asking user on floor plan
        Console.Write("What is the shape of your room?");
        string roomShape = Console.ReadLine();
        if (roomShape == "square")
        {
            // User inputs width
            Console.Write("Enter the width needed: ");
            decimal unitWidth = decimal.Parse(Console.ReadLine());
       
            // User inputs length
            Console.Write("Enter the length needed: ");
            decimal unitLength = decimal.Parse(Console.ReadLine());
            
            // Outputs the calculation of cost needed to purchase enough flooring for area
            decimal calculationOfArea = unitWidth * unitLength * cost;
            Console.WriteLine($"The cost of your flooring would be: ${calculationOfArea}");
        }
        if (roomShape == "triangular")
        {
            Console.Write("Input base of triangular flooring: ");
            double triangularBase = double.Parse(Console.ReadLine());
        
            Console.Write("Input height of triangular flooring: ");
            double triangularHeight = double.Parse(Console.ReadLine());
            double formulaAreaOfTriangle = .5 * (triangularBase * triangularHeight);
        
            Console.WriteLine($"The cost of your flooring would be: ${formulaAreaOfTriangle}");
        }
        
        if (roomShape == "circular"){
            Console.Write("Input radius of circular floor: ");
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal pi = 3.14159265358979323846m;
            decimal formulaAreaOfCircle = pi * (radius * radius);
            decimal calculatedCostOfFlooring = formulaAreaOfCircle * cost;
            Console.WriteLine($"The cost of your flooring would be: ${calculatedCostOfFlooring}");
            
            /* So I have tried decimal to get more of a precise calculation.
       I believe that would be the correct route to go since we are working with cost.
       What could I add to make the finished calculation more in a standard currency amount with only 2 placements after the decimal? */   

       }
    }
}