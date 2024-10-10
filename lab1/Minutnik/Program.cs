using System;
using System.Threading;
using MinutnikLib;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine( "Hello, World!" );

        // Biblioteka MinutnikLib
        /*
        DateTime end = new DateTime(2024, 10, 7, 18, 40, 0);
        MinutnikLib.MinutnikLib minutnik = new MinutnikLib.MinutnikLib(end);
        //Console.ReadKey();
        */
        // Tablice
        DateTime start = DateTime.Now;
        int[] tab = new int[1000000];
        int sum = 0;
        for (int i = 0; i < tab.Length; i++) {
            tab[i] = i;
            sum += tab[i];
        }
        //System.Console.WriteLine(sum);
        System.Console.WriteLine(DateTime.Now - start);

        // zad 7
        start = DateTime.Now;
        object[] tab2 = new object[1000000];
        sum = 0;
        for (int i = 0; i < tab2.Length; i++) {
            tab2[i] = i;
            sum += (int)tab2[i];
        }
        //System.Console.WriteLine(sum);
        System.Console.WriteLine(DateTime.Now - start);

        // zad 8
        int result = Sum(1, 2, 4, 3, 5);
        System.Console.WriteLine(result);

        // zad 9
        float avg;
        result = SumAvg(out avg, 1, 2, 3, 4, 5);
        System.Console.WriteLine(result);
        System.Console.WriteLine(avg);
        
        // zad 10
        Point p = new Point();
        p.Print();

        // zad 12 / 13
        Point p1 = new Point(1, 1);
        Point p2 = p1;
        p2.Print();

        p1.x = 5;
        p1.Print();
        p2.Print();

        // zad 14
        PointC pc = new PointC(1, 2);
        pc.Print();

        PointC pc1 = new PointC(1, 1);
        PointC pc2 = pc1;
        pc2.Print();

        pc1.x = 5;
        pc1.Print();
        pc2.Print();

        // zad 15
        p.Print();
        ChangeS(p);
        p.Print();
        pc.Print();
        ChangeC(pc);
        pc.Print();
    }

    public static int Sum(params int[] args) {
        int sum = 0;
        for (int i = 0; i < args.Length; i++) {
            sum += (int)args[i];
        }
        return sum;
    }

    public static int SumAvg(out float avg, params int[] args) {
        int sum = 0;
        for (int i = 0; i < args.Length; i++) {
            sum += (int)args[i];
        }
        avg = sum / args.Length;
        return sum;
    }

    public static void ChangeS(Point p) {
        p.x++;
        p.y++;
    }

    public static void ChangeC(PointC p) {
        p.x++;
        p.y++;
    }
}

struct Point {
    public int x { get; set; }
    public int y { get; set; }

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void Print() {
        System.Console.WriteLine("Struct\nx = {0}\ny = {1}\n", x, y);
    }
}

class PointC {
    public int x { get; set; }
    public int y { get; set; }

    public PointC(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void Print() {
        System.Console.WriteLine("Class\nx = {0}\ny = {1}\n", x, y);
    }
}