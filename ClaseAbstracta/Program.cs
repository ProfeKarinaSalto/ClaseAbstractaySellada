using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// modifiqué en rama local

namespace ClaseAbstracta
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Auto auto2 = new Auto(4, "VW", "2020", 2, true);
            auto2.mostrarInformacion();

            Console.WriteLine("Ingrese cant. de ruedas: ");
            int ruedas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese marca: "); 
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese cant. de puertas: ");
            int puertas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Tiene cierre automático? True/False: ");
            bool cierreAutomatico = bool.Parse(Console.ReadLine());

            Auto auto3 = new Auto(ruedas,marca,modelo,puertas,cierreAutomatico);
            auto3.mostrarInformacion();

            
            AutoElectrico auto4 = new AutoElectrico(4, "Peugeot", "202", 2, false, 220);
            auto4.mostrarInformacion();
            auto4.infoAutoElectrico();
            auto4.MostrarLeyenda();

            Moto moto1 = new Moto(2, "Zuzuqui", "2007");
            moto1.mostrarInformacion();
            moto1.MostrarLeyenda();


            Console.ReadKey();


        }
    }
}
