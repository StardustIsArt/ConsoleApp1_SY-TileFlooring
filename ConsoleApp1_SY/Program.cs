namespace ConsoleApp1_SY;
class Program
{ static void Main(string[] args)
    {
        const decimal YARDS_PER_HOUR = 20;
        const decimal HOURLY_RATE = 86.00M;
        // Asking the user to input width, length and cost of the 1 unit of flooring.
        Console.WriteLine("Please provide the width, length and cost of one unit of flooring to calculate the entire cost of flooring needed.");
        
        // User inputs cost of one unit of flooring
        Console.Write("Enter the cost of one unit of flooring: $");
        decimal cost = decimal.Parse(Console.ReadLine());
        decimal area = 0;
        
        // Asking user on floor plan
        Console.Write("What is the shape of your room? square | triangular | circular\n");
        string roomShape = Console.ReadLine();
        string[] roomShapeInput = ["square", "triangular", "circular"];
        if (roomShape != roomShapeInput[0] && roomShape != roomShapeInput[1] && roomShape != roomShapeInput[2]) {
            Console.WriteLine("You must enter a valid room shape.");
            return;
        } 
        
        if (roomShape == roomShapeInput[0]) {
            // User inputs width
            Console.Write("Enter the width needed: ");
            decimal unitWidth = decimal.Parse(Console.ReadLine());
            // User inputs length
            Console.Write("Enter the length needed: ");
            decimal unitLength = decimal.Parse(Console.ReadLine());
            area = unitWidth * unitLength;
            decimal squareFlooringCost = area * cost;
            Console.WriteLine($"The cost of your flooring would be: ${squareFlooringCost}");
        }

        if (roomShape == roomShapeInput[1]) {
            Console.Write("Input base of triangular flooring: ");
            double triangularBase = double.Parse(Console.ReadLine());
            Console.Write("Input height of triangular flooring: ");
            double triangularHeight = double.Parse(Console.ReadLine());
            area = (decimal)(.5 * (triangularBase * triangularHeight));
            decimal triangleFlooringCost = area * cost;
            Console.WriteLine($"The cost of your flooring would be: ${triangleFlooringCost}");
        }
        
        if (roomShape == roomShapeInput[2]){
            Console.Write("Input radius of circular floor: ");
            decimal radius = decimal.Parse(Console.ReadLine());
           // double pi = Math.PI;
            area = (decimal)(Math.PI * (double)(radius * radius));
            decimal circularFlooringCost = area * cost;
            Console.WriteLine($"The cost of your flooring would be: ${circularFlooringCost}");
        }
        
        decimal totalHours = area/YARDS_PER_HOUR;
        decimal totalLaborCost = totalHours * HOURLY_RATE;
        Console.WriteLine($"The estimated cost of labor for {area} units of sq. ft. is ${totalLaborCost}");
    }
}