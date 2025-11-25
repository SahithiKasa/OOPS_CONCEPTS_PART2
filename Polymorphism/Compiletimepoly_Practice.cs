using System;


class MarksCalculator
{
    // 1️⃣ Method Overloading: 2 subjects
    public int CalculateTotal(int sub1, int sub2)
    {
        return sub1 + sub2;
    }

    // 2️⃣ Method Overloading: 3 subjects
    public int CalculateTotal(int sub1, int sub2, int sub3)
    {
        return sub1 + sub2 + sub3;
    }

    // 3️⃣ Method Overloading: 3 subjects + grace marks
    public int CalculateTotal(int sub1, int sub2, int sub3, int grace)
    {
        return sub1 + sub2 + sub3 + grace;
    }

    // 4️⃣ Method Overloading: array of marks
    public int CalculateTotal(int[] marks)
    {
        int total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total =total+ marks[i];
        }

        return total;
    }
}

class Program7
{
    static void Main()
    {
        MarksCalculator calculator = new MarksCalculator();

        Console.WriteLine("Total (2 subjects): " +
            calculator.CalculateTotal(50, 60));

        Console.WriteLine("Total (3 subjects): " +
            calculator.CalculateTotal(40, 50, 60));

        Console.WriteLine("Total (3 subjects + grace): " +
            calculator.CalculateTotal(40, 50, 60, 10));

        int[] allMarks = { 45, 55, 60, 70 };
        Console.WriteLine("Total (Array of 4 subjects): " +
            calculator.CalculateTotal(allMarks));
    }
}
