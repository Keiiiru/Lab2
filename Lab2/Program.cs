namespace Lab2
{
    public class Solver
    {
        public double x, y;

        public Solver() { x = 0; y = 0; }
        public Solver(double X) { x = X; y = 0; }
        public Solver(double X, double Y) { x = X; y = Y; }

        public double Result => Math.Sqrt((Math.Pow(x, 2) - Math.Pow(0, 2)) + (Math.Pow(y, 2) - Math.Pow(0, 2)));

        public void WriteResult()
        {
            Console.WriteLine(
                "Точка в пространстве:\n" +
                "x = {0}\n" +
                "y = {1}",
                x, y
            );
            Console.WriteLine("Расстояние = {0}", Result);
        }
    }

    public class Lab2
    {
        public static void ConfigureConsole()
        {
            Console.Title = "Расстояние до точки";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public static (double x, double y) GetInput()
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            return (x, y);
        }

        public static void Main()
        {
            ConfigureConsole();
            (double x, double y) = GetInput();
            Solver solver = new(x, y);
            solver.WriteResult();
        }
    }
}