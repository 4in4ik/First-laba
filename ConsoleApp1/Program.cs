using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoes O = new Shoes();
            

           

            O.S(Console.ReadLine(),Convert.ToSingle(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            O.Print();
            Console.ReadKey();
        }
    }
    public class Shoes
    {
        string proizvoditel;
        float size;
        double price;
        public void Print()
        {
            Console.WriteLine($"Производитель:{proizvoditel}\nРазмер:{size}\nЦена:{price}");       
        }
        public void S(string Sp, float Ss, double SP)
        {
            proizvoditel = Sp;
            size = Ss;
            price = SP;
        }
    }
}
