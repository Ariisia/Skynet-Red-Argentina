using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    class GeneracionDeClaves
    {

        Random aleatorio = new Random();
        int clavePMC, claveHomebaking, claveSkynet;

        public void generacionDeClaves()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("¿Que tipo de clave desea generar?");
                Console.WriteLine();
                Console.WriteLine("1 Clave PMC");
                Console.WriteLine("2 Clave Homebanking");
                Console.WriteLine("3 Clave Skynet");
                Program.menu = Console.ReadLine();

                while (Program.menu != "1" && Program.menu != "2" && Program.menu != "3")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                    Console.WriteLine();
                    Console.WriteLine("¿Que tipo de consulta desea realizar?");
                    Console.WriteLine();
                    Console.WriteLine("1 Clave PMC");
                    Console.WriteLine("2 Clave Homebanking");
                    Console.WriteLine("3 Clave Skynet");
                    Program.menu = Console.ReadLine();
                }

                switch (Program.menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Su nueva clave PMC es:");
                        Console.WriteLine();
                        clavePMC = aleatorio.Next(1000, 9999);
                        Console.WriteLine(clavePMC);
                        Console.WriteLine();
                        Console.WriteLine("Presione tecla Enter para continuar.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Su nueva clave Homebanking es:");
                        Console.WriteLine();
                        claveHomebaking = aleatorio.Next(100000, 999999);
                        Console.WriteLine(claveHomebaking);
                        Console.WriteLine();
                        Console.WriteLine("Presione tecla Enter para continuar.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Su nueva clave Skynet es:");
                        Console.WriteLine();
                        claveSkynet = aleatorio.Next(10000000, 99999999);
                        Console.WriteLine(claveSkynet);
                        Console.WriteLine();
                        Console.WriteLine("Presione tecla Enter para continuar.");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
                Console.WriteLine("¿Desea generar otra clave?");
                Program.ask = "¿Desea generar otra clave?";
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                Program.menu = Console.ReadLine();
                Program.menu = Program.verificacion(Program.ask, Program.menu);

            } while (Program.menu == "1");
        }
    }
}
