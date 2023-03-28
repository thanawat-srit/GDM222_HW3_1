﻿class Program {
    static void Main(string[] args) {
        double h, k;
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        h = ((y2 - y1) * (y3 * y3 - y1 * y1 + x3 * x3 - x1 * x1) + (y3 - y1) * (y1 * y1 - y2 * y2 + x1 * x1 - x2 * x2)) / (2 * (x3 - x1) * (y2 - y1) - 2 * (x2 - x1) * (y3 - y1));
        k = ((x2 - x1) * (x3 * x3 - x1 * x1 + y3 * y3 - y1 * y1) + (x3 - x1) * (x1 * x1 - x2 * x2 + y1 * y1 - y2 * y2)) / (2 * (y3 - y1) * (x2 - x1) - 2 * (y2 - y1) * (x3 - x1));

        double r = Math.Sqrt((x1 - h) * (x1 - h) + (y1 - k) * (y1 - k));

        Console.WriteLine(h);
        Console.WriteLine(k);
        Console.WriteLine(r);
    }
}