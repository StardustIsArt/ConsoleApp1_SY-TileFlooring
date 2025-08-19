namespace ConsoleApp1_SY;

class Program
{
    static void Main(string[] args)
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
        string[] roomShapeInput = ["triangular", "square", "circular"];
        /*const string TRIANGULAR_SHAPE_TYPE = "triangular";
        const string SQUARE_SHAPE_TYPE = "square";
        const string CIRCULAR_SHAPE_TYPE = "circular";*/
        
        if (roomShape == null) {
            Console.WriteLine("You must enter a valid room shape.");
        }
        
        if (roomShape == roomShapeInput[1]) {
            // User inputs width
            Console.Write("Enter the width needed: ");
            decimal unitWidth = decimal.Parse(Console.ReadLine());
            // User inputs length
            Console.Write("Enter the length needed: ");
            decimal unitLength = decimal.Parse(Console.ReadLine());
            decimal area = unitWidth * unitLength;
            decimal squareFlooringCost = area * cost;
            Console.WriteLine($"The cost of your flooring would be: ${squareFlooringCost}");
           // decimal totalHours = squareFlooringCost * YARDS_PER_HOUR;
           // decimal TOTAL_HOURS = area/YARDS_PER_HOUR;
            //decimal totalLaborCost = TOTAL_HOURS * HOURLY_RATE;
           // Console.WriteLine($"The estimated cost of labor for {area} units of sq. ft. is ${totalLaborCost}");
            // Outputs the calculation of cost needed to purchase enough flooring for area
            decimal calculationOfArea = unitWidth * unitLength * cost;
            Console.WriteLine($"The cost of your flooring would be: ${calculationOfArea}");
        }
        
        if (roomShape == roomShapeInput[0]) {
            Console.Write("Input base of triangular flooring: ");
            double triangularBase = double.Parse(Console.ReadLine());
            Console.Write("Input height of triangular flooring: ");
            double triangularHeight = double.Parse(Console.ReadLine());
            double area = .5 * (triangularBase * triangularHeight);
            double triangleFlooringCost = area * (double)cost;
            Console.WriteLine($"The cost of your flooring would be: ${triangleFlooringCost}");
           // double totalHours = triangleFootage / (double)YARDS_PER_HOUR;
           // decimal TOTAL_HOURS = (decimal)area/YARDS_PER_HOUR;
            //decimal totalLaborCost = TOTAL_HOURS * HOURLY_RATE;
            //Console.WriteLine($"The estimated cost of labor for {area} units of sq. ft. is ${totalLaborCost}");
        }
        
        if (roomShape == roomShapeInput[2]){
            Console.Write("Input radius of circular floor: ");
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal pi = 3.14159265358979323846m;
            area = pi * (radius * radius);
            decimal circularFlooringCost = area * cost;
            Console.WriteLine($"The cost of your flooring would be: ${circularFlooringCost}");
          //  decimal TOTAL_HOURS = area/YARDS_PER_HOUR;
            //decimal totalLaborCost = TOTAL_HOURS * HOURLY_RATE;
        }
        decimal totalHours = area/YARDS_PER_HOUR;
        decimal totalLaborCost = totalHours * HOURLY_RATE;
        Console.WriteLine($"The estimated cost of labor for {area} units of sq. ft. is ${totalLaborCost}");
    }
}