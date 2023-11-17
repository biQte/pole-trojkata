namespace pole_trojkata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczenie pola trójkąta");
            Console.WriteLine("Podaj długość podstawy:");
            float baseLength = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość trójkąta:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole trójkąta o podanych wymiarach wynosi: " + ((baseLength * height) / 2) + " jednostek kwadratowych");
        }
    }
}