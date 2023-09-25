using System;

class Shar
{
    private double r;

    public Shar()
    {
        r = 0.0;
    }

    public double Radius
    {
        get { return r; }
        set
        {
            if (value >= 0)
                r = value;
            else
                Console.WriteLine("Попередження: Радiус повинен бути додатнiм.");
        }
    }

    public bool Correct()
    {
        return r > 0;
    }

    public double Area()
    {
        return Math.Round(4 * Math.PI * r * r, 2);
    }

    public double Volume()
    {
        return Math.Round((4.0 / 3.0) * Math.PI * r * r * r, 2);
    }

    public void Print()
    {
        Console.WriteLine($"Радiус кулi: {r:F2}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Shar shar = new Shar();
            Console.Write("Введiть значення радiуса: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            shar.Radius = radius;

            shar.Print();

            if (shar.Correct())
            {
                Console.WriteLine($"Площа поверхнi кулi: {shar.Area()}");
                Console.WriteLine($"Об'єм кулi: {shar.Volume()}");
            }
            else
            {
                Console.WriteLine("Об'єкт не iснує.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}