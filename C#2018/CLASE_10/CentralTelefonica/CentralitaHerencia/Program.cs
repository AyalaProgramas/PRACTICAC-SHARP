using System;
using System.Collections.Generic;//
using System.Linq;
using System.Text;

using Entidades;
namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita("Telecentro");
                       
            Local llamadaUno = new Local("123",30, "456", 2.65f);           
           
            Provincial llamadaDos = new Provincial("987",Franja.Franja_1,21,"333");

            Local llamadaTres = new Local("123", 45, "455", 1.99f);

            Provincial llamadaCuatro = new Provincial(Franja.Franja_3,llamadaDos);

            Telefonica.Llamada.Add(llamadaUno);
            Telefonica.Llamada.Add(llamadaDos);
            Telefonica.Llamada.Add(llamadaTres);
            Telefonica.Llamada.Add(llamadaCuatro);

            Console.WriteLine("Muestro a traves de Telefonica\n" + Telefonica.Mostrar());

            Console.WriteLine("\nMuestro a traves de las llamadas\n");

            Console.WriteLine("\nLlamada 1: " + llamadaUno.Mostrar());
                                              
            Console.WriteLine("\nLlamada 2: " + llamadaDos.Mostrar());

            Console.WriteLine("\nLlamada 3: " + llamadaTres.Mostrar());

            Console.WriteLine("\nLlamada 4: " + llamadaCuatro.Mostrar());

            Console.ReadKey();
            
        }
    }
}
