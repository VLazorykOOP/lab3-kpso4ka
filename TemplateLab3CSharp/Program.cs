using System;

namespace Program
{
    class Trapeze
    {
        private int a, b, c, d;
        private readonly int color;

        public Trapeze(int a, int b, int c, int d, int color)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.color = color;
        }

        public void Print()
        {
            Console.WriteLine($"A: {a}\nB: {b}\nC: {c}\nD: {d}\nColor: {color}");
        }

        public double P()
        {
            return a + b + c + d;
        }

        public double S()
        {
            double p = P() / 2;
            return ((a + b) / (Math.Abs(a - b) * Math.Sqrt((p - a) * (p - b) * (p - a - c) * (p - a - d))));
        }

        public bool IsSquare()
        {
            if (a == b && b == c && c == d) return true;
            return false;
        }

        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public int getC()
        {
            return c;
        }
        public int getD()
        {
            return d;
        }
        public int getColor()
        {
            return color;
        }

        public void setA(int newA)
        {
            a = newA;
        }
        public void setB(int newA)
        {
            b = newA;
        }
        public void setC(int newA)
        {
            c = newA;
        }
        public void setD(int newA)
        {
            d = newA;
        }

    }

    class Test
    {
        public string question;

        public Test()
        {
            question = "none";
        }

        public Test(string quest)
        {
            question = quest;
        }

        public void Show()
        {
            Console.WriteLine($"Question: {question}");
        }
    }

    class Ispyt : Test
    {
        private double maxOcinka;
        public Ispyt()
        {
            question = "none";
            maxOcinka = 0;
        }

        public Ispyt(double ocinka, string quest)
        {
            maxOcinka = ocinka;
            question = quest;
        }

        public Ispyt(double ocinka)
        {
            maxOcinka = ocinka;
        }

        public void Show()
        {
            Console.WriteLine($"Question: {question}");
            Console.WriteLine($"Max ocinka: {maxOcinka}");
        }
    }

    class VipyskniyIspyt : Test
    {
        private double prohidnyi;
        public VipyskniyIspyt()
        {
            question = "none";
            prohidnyi = 0;
        }

        public VipyskniyIspyt(double ocinka, string quest)
        {
            prohidnyi = ocinka;
            question = quest;
        }

        public VipyskniyIspyt(double ocinka)
        {
            prohidnyi = ocinka;
        }

        public void Show()
        {
            Console.WriteLine($"Question: {question}");
            Console.WriteLine($"Prohidnyi: {prohidnyi}");
        }
    }

    class Vyprobyvannya : Test
    {
        private double prohidnyi;
        public Vyprobyvannya()
        {
            question = "none";
            prohidnyi = 0;
        }

        public Vyprobyvannya(double ocinka, string quest)
        {
            prohidnyi = ocinka;
            question = quest;
        }

        public Vyprobyvannya(double ocinka)
        {
            prohidnyi = ocinka;
        }

        public void Show()
        {
            Console.WriteLine($"Question: {question}");
            Console.WriteLine($"Ocinka: {prohidnyi}");
        }
    }



    static class Program
    {
        static void Main()
        {
            var arr = new List<Trapeze> {
             new Trapeze(1, 1, 1, 1, 1),
             new Trapeze(11, 15, 4, 4, 2),
             new Trapeze(2, 6, 6, 3, 3),
             new Trapeze(4, 14, 15, 6, 1),
             new Trapeze(2, 2, 2, 2, 2)
            };
            int squares = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine($"Trapezia {i}");
                Console.WriteLine($"P: {arr[i].P()}");
                Console.WriteLine($"S: {arr[i].S()}");
                Console.WriteLine($"Color: {arr[i].getColor()}");
                Console.WriteLine($"isSquare: {arr[i].IsSquare()}");
                if (arr[i].IsSquare()) squares++;
            }
            Console.WriteLine($"Squares: {squares}");
            Console.WriteLine();

            Test test = new Test("test");
            test.Show();
            Console.WriteLine();
            Ispyt ispyt = new Ispyt(20, "ispyt");
            ispyt.Show();
            Console.WriteLine();
            VipyskniyIspyt vipyskniyIspyt = new VipyskniyIspyt(30, "vipysk");
            vipyskniyIspyt.Show();
            Console.WriteLine();
            Vyprobyvannya vyprobyvannya = new Vyprobyvannya(5, "vyprobyvannya");
            vyprobyvannya.Show();
            Console.WriteLine();
        }
    }
}
