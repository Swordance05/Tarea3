using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static String name = "";
        static int mes = 0;
        static int Main()
        {

            Console.WriteLine("Hola mundo");
            Console.Write("Digite un su nombre");
            name = Console.ReadLine();
            Console.WriteLine("Buenas tardes" + name);
            Console.WriteLine("Digite su numero de nacimiento");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1)
            {

                Console.WriteLine("Eres Acuario");
            }

            

            if (mes == 2)
            {

                Console.WriteLine("Eres Piscis");
            }

            

            if (mes == 3)
            {

                Console.WriteLine("Eres Aries");
            }

           

            if (mes == 4)
            {

                Console.WriteLine("Eres Tauro");
            }

            

            if (mes == 5)
            {

                Console.WriteLine("Eres Geminis");
            }

            

            if (mes == 6)
            {

                Console.WriteLine("Eres Cancer");
            }

            

            if (mes == 7)
            {

                Console.WriteLine("Eres Leo");
            }

            

            if (mes == 8)
            {

                Console.WriteLine("Eres Virgo");
            }

            

            if (mes == 9)
            {

                Console.WriteLine("Eres Libra");
            }

            

            if (mes == 10)
            {

                Console.WriteLine("Eres Escorpion");
            }

           

            if (mes == 11)
            {

                Console.WriteLine("Eres Sagitario");
            }

            

            if (mes == 12)
            {

                Console.WriteLine("Eres Capricornio");
            }

            

            if (mes > 12){

                Console.WriteLine("A sobrepasado el limite de mes");

            }

            if (mes == null) {

                Console.WriteLine("Sin informacion");
            
            }





            Console.ReadKey();
            return 0;



        }
    }
}
