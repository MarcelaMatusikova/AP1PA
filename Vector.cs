using System;

namespace vektory
{
    struct Bod
    {
        public int x;
        public int y;

        public Bod(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
    }

    struct Vektor
    {
        Bod pocatek;
        Bod konec;

        public Vektor(Bod pocatek, Bod konec)
        {
            this.pocatek = pocatek;
            this.konec = konec;
        }

        public int usecka1()
        {
            return konec.x - pocatek.x;
        }
        public int usecka2()
        {
            return konec.y - pocatek.y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bod A = new Bod(2, 2);
            Bod B = new Bod(9, 7);
            Bod C = new Bod(1, 1);
            Bod D = new Bod(3, 4);

            Vektor u = new Vektor(A,B);
            Vektor v = new Vektor(C,D);
            int skalarniSoucin = u.usecka1() * v.usecka1() + u.usecka2() * v.usecka2();
            int u1 = u.usecka1() + v.usecka1();
            int u2 = u.usecka2() + v.usecka2();
            Console.WriteLine($"Vysledek souctu je: ({u1} , {u2})");
        }
    }
}
