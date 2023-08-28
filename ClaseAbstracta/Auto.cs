using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class Auto:Vehículo
    {
            
        private int puertas;
        private bool cierreAutomatico;

        public bool CierreAutomatico { get => cierreAutomatico; set => cierreAutomatico = value; }
        

        public int Puertas {
            get{
                return puertas;
            }
            set{
                if(value<3 || value>6) puertas=3;
                else puertas=value;
            }
        }

       
        public Auto(int ruedas,string marca, string modeloCoche, int puertasCoche, bool cierreAutomaticoCoche): base(ruedas, marca, modeloCoche)
        {
            puertas=puertasCoche;
            cierreAutomatico=cierreAutomaticoCoche;
        }

        public override void mostrarInformacion()
        {

            Console.WriteLine("*********************Auto************************");
            if (puertas < 4)
            {
                Console.WriteLine("Autos con 3 puertas: ");
                Console.WriteLine($"Cant. de ruedas: {Ruedas} marca: {Marca} modelo: {Modelo} puertas: {puertas} cierre automático: {CierreAutomatico}");
            }
            else
            {
                Console.WriteLine("Autos con 5 puertas: ");
                Console.WriteLine($"Cant. de ruedas: {Ruedas} marca: {Marca} modelo: {Modelo} puertas: {puertas} cierre automático: {CierreAutomatico}");

            }

        }




    }
}