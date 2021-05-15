using System;

namespace lol
{
    class Program
    {
        static void Main(string[] args)
        {
            int m50 = 2;
            int sobrepe = 3;
            int tabaquis = 4;
            int sedenta = 3;
            int diabetes = 3;
            int edad;
            int resultado = 0;
            string r1, r2, r3, r4;
            string name;
            string indice;
            string res;

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("             Programa de Indice de riesgo cardiovascular  ");
            Console.WriteLine("**************************************************************************************");

            while (true) {

            Console.WriteLine("Digite su nombre");
            name = Console.ReadLine();
            Console.WriteLine("Por favor indique su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("usted tiene sobrepeso S/N");
            r1 = Console.ReadLine();
            Console.WriteLine("Usted sufre de Tabaquismo S/N");
            r2 = Console.ReadLine();
            Console.WriteLine("Usted tiene Sedentarismo S/N");
            r3 = Console.ReadLine();
            Console.WriteLine("Usted tiene Diabetes S/N");
            r4 = Console.ReadLine();
            if (edad >= 50)
            {
                resultado = resultado + m50;
            }
            if (r1 == "s" || r1 == "S")
            {
                resultado = resultado + sobrepe;
            }
            if (r2 == "s" || r2 == "S")
            {
                resultado = resultado + tabaquis;
            }
            if (r3 == "s" || r3 == "S")
            {
                resultado = resultado + sedenta;
            }
            if (r4 == "s" || r4 == "S")
            {
                resultado = resultado + diabetes;
            }

            if (resultado >= 0 && resultado <= 5)
            {
                indice = "Baja";
            }
            else if (resultado > 5 && resultado <= 10)
            {
                indice = "Moderado";
            }
            else
            {
                indice = "Alto";
            }

            Console.WriteLine("Sr(a) " + name + " Su indice de sufrir una enfermedad cardiaca es: "
                + indice + ", ya que tiene un indice de: " + resultado);

             Console.WriteLine("\nDesea continuar: S/N");
                res = Console.ReadLine();
                resultado = 0;
            if (res=="s" || res == "S")
            {
                    System.Console.Clear();
               continue;
            }
            else
                {
               break;
            }
        }
        }
    }
}
