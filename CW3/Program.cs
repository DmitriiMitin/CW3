using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden Vasya = new Garden();
            Vasya.Work();
            Console.WriteLine();
        }
    }

    interface IClonable
    {
        void Work();
    }

    public class Stack : ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Technic
    {
        public string Manufacturer { get; set; }
        public string Power { get; set; }
        public EnergyConsumptionType EnergyConsumptiontype { get; set; }
        public string Name { get; set; }
    }

    public enum EnergyConsumptionType
    {
        A,
        B, 
        C,
        D,
        E,
        F,
        G
    }

    public class Garden : Technic
    {
        public Seasonality Seasonality { get; set; }

        public void Work()
        {
            if (Seasonality != Seasonality.Summer)
            {
                Console.WriteLine("Неподходящий сезон, работа садововой техники прекращена");
            }
            else
            {
                Console.WriteLine("Садовая техника работает");
            }

            if (Seasonality != Seasonality.Autumn)
            {
                Console.WriteLine("Неподходящий сезон, работа садововой техники прекращена");
            }
            else
            {
                Console.WriteLine("Садовая техника работает");
            }
        }
    }


    public enum Seasonality
    {
        Summer,
        Autumn
    }
}
