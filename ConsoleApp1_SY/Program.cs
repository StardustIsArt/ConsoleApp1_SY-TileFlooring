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
        Console.Write("What is the shape of your room? square | triangular | circular\n");
        string roomShape = Console.ReadLine();
        if (roomShape == null)
        {
            Console.WriteLine("You must enter a valid room shape.");
        }
        if (roomShape == "square")
        {
            // User inputs width
            Console.Write("Enter the width needed: ");
            decimal unitWidth = decimal.Parse(Console.ReadLine());
       
            // User inputs length
            Console.Write("Enter the length needed: ");
            decimal unitLength = decimal.Parse(Console.ReadLine());
            decimal squareFootage = unitWidth * unitLength;
            
            decimal squareFlooringCost = squareFootage * cost;
            Console.WriteLine($"The cost of your flooring would be: ${squareFlooringCost}");
            decimal totalHours = squareFootage/20;
            decimal totalLaborCost = totalHours * 86.00M;
            Console.WriteLine($"The estimated cost of labor for {squareFootage} units of sq. ft. is ${totalLaborCost}");

        }
        if (roomShape == "triangular")
        {
            Console.Write("Input base of triangular flooring: ");
            double triangularBase = double.Parse(Console.ReadLine());
            
            Console.Write("Input height of triangular flooring: ");
            double triangularHeight = double.Parse(Console.ReadLine());
            double triangleFootage = .5 * (triangularBase * triangularHeight);
            double triangleFlooringCost = triangleFootage * (double)cost;
            
            Console.WriteLine($"The cost of your flooring would be: ${triangleFlooringCost}");
            double totalHours = triangleFootage / 20;
            double totalLaborCost = totalHours * 86.00;
            Console.WriteLine($"The estimated cost of labor for {triangleFootage} units of sq. ft. is ${totalLaborCost}");
        }
        if (roomShape == "circular")
        {
            Console.Write("Input radius of circular floor: ");
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal pi = 3.14159265358979323846m;
            decimal circularFootage = pi * (radius * radius);
            decimal circularFlooringCost = circularFootage * cost;
            
            Console.WriteLine($"The cost of your flooring would be: ${circularFlooringCost}");
            decimal totalHours = circularFootage / 20;
            decimal totalLaborCost = totalHours * 86.00M;
            Console.WriteLine($"The estimated cost of labor for {circularFootage} units of sq. ft. is ${totalLaborCost}");
        }
        
        
        // for 1 hour the workers can get in 20 sq. ft. of flooring...
        // how much flooring is there? results of calculations from different flooring shapes.
        // Is there a way to call the different "(square, triangle, circular)Footage" into a different section?
        // for every 20 sq. ft. = 1 hr = $86.00 in labor cost. How many hours of labor does it take to finish the flooring?
        // -> x amount of hours * 86.00 = totalLaborCost
    }
}