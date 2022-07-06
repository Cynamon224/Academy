using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_MM
{
    //Single responsibility principle

    public class Dodawanie2 
    {
        public int a;
        public int b;
        public Dodawanie2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int dodawanie()
        {
            return a + b;
        }

    }

    public class Odejmowanie1
    {
        public int a;
        public int b;
        public Odejmowanie1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int odejmowanie()
        {
            return a - b;
        }
    }

    ///Open/Closed Principle

    public abstract class Ksztalt
    {
        public abstract double Pole();
    }

    public class Kwadrat : Ksztalt
    {
        public int a;
        public Kwadrat(int a)
        {
            this.a = a;
        }   
        public override double Pole()
        {
            return a * a;
        }
    }

    public class Trojkat : Ksztalt
    {
        public int a;
        public int h;
        public Trojkat(int a, int h)
        {
            this.a = a;
            this.h = h;
        }
        public override double Pole()
        {
            return a * h*0.5;
        }
    }

    /// Liskov Substitution Principle
    public abstract class KolorC
    {
        public abstract void Kolor();
    }
    public class Jablko : KolorC
    {
        public override void Kolor()
        {
            Console.WriteLine("czerwony");
        }
    }

    public class Banan : KolorC
    {
        public override void Kolor()
        {
            Console.WriteLine("zolty");
        }
    }

    /// Interface segregation principle
    
    public interface Wyplata
    {
        void Wyplata();
    }
    public interface DniWolne
    {
        void DniWolne();
    }
    public class Pracownik1 : Wyplata
    {
        public void Wyplata()
        {
            Console.WriteLine("Wyplata wynosi x");
        }
    }

    public class Pracownik2 : DniWolne
    {
        public void DniWolne()
        {
            Console.WriteLine("Ilosc dni wolnych wynosi x");
        }
    }

    ///Dependency Inversion Principle

    public interface IName
    {
        string GetName(string name);
    }
    public class Person : IName
    {
        public Person() { }
        public string GetName(string name)
        {
            return "jakies imie";
        }
    }

    public class Company 
    {
        public static IName NameObj()
        {
            return new Person();
        }
    }
    public class Business
    {
        IName _custName;
        public Business()
        {
        _custName=Company.NameObj();
        }
        public string GetName(string name) { return _custName.GetName(name); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
