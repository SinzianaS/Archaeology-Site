using System;

namespace ArchaeologySite
{
    class Program
    {
        static void Main(string[] args)
        {
            double verticeAx = Convert.ToDouble(Console.ReadLine());
            double verticeAy = Convert.ToDouble(Console.ReadLine());
            double verticeBx = Convert.ToDouble(Console.ReadLine());
            double verticeBy = Convert.ToDouble(Console.ReadLine());
            double verticeCx = Convert.ToDouble(Console.ReadLine());
            double verticeCy = Convert.ToDouble(Console.ReadLine());
            double minimalArea = 0.5 * (verticeAx * (verticeBy - verticeCy) + verticeBx * (verticeCy - verticeAy) + verticeCx * (verticeAy - verticeBy));
            double v = Math.Abs(minimalArea);
            Console.WriteLine(v);
            Console.Read();
        }
    }
}

