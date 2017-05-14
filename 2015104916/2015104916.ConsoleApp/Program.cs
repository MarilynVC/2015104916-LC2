using _2015104916.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2015104916.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var ensambladora = new Ensambladora();
            Carro Carro1 = ensambladora.EnsamblarCarro(TipoCarro.Bus, TipoBus.Privado,TipoAuto.Coupe);
            ensambladora.Agregar(Carro1);
            Carro Carro2 = ensambladora.EnsamblarCarro(TipoCarro.Bus, TipoBus.Publico, TipoAuto.Coupe);
            ensambladora.Agregar(Carro2);
            Carro Carro3 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Privado, TipoAuto.Sedan);
            ensambladora.Agregar(Carro3);
            Carro Carro4 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Publico, TipoAuto.PickUp);
            ensambladora.Agregar(Carro4);
            Carro Carro5 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Privado, TipoAuto.HatchBack);
            ensambladora.Agregar(Carro5);
            Carro Carro6 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Publico, TipoAuto.Coupe);
            ensambladora.Agregar(Carro6);
            string opc;
            Console.WriteLine("Desea Iniciar la Personalizacion? Y(Si)/N(No)");
            opc=Console.ReadLine();

            while (true) {

            if (opc.CompareTo("Y") == 0 || opc.CompareTo("y") == 0)
            {
                ensambladora.IniciarPersonalizacion();
                Thread.Sleep(5000);
                ensambladora.FinalizarPersonalizacion();
               break;

            }
            else if (opc.CompareTo("N") == 0 || opc.CompareTo("n") == 0)
            {
                Console.WriteLine("Regrese pronto");
                break;

            }
            else
            {
                Console.WriteLine("Escriba una opcion válida");
               Console.WriteLine("Desea iniciar la personalizacion? Y(Si)/N(No)");
               opc = Console.ReadLine();
            }

           }
        }
    }
}
