using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    class Consultas
    {
        public void consultas()
        {
            do
            {

                Console.Clear();
                Console.WriteLine("¿Que tipo de consulta desea realizar?");
                Console.WriteLine();
                Console.WriteLine("1 Consulta de saldo");
                Console.WriteLine("2 Ultimos Movimientos");
                Console.WriteLine("3 Consulta de CBU");
                Program.menu = Console.ReadLine();

                while (Program.menu != "1" && Program.menu != "2" && Program.menu != "3")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                    Console.WriteLine();
                    Console.WriteLine("¿Que tipo de consulta desea realizar?");
                    Console.WriteLine();
                    Console.WriteLine("1 Consulta de saldo");
                    Console.WriteLine("2 Ultimos Movimientos");
                    Console.WriteLine("3 Consulta de CBU");
                    Program.menu = Console.ReadLine();
                }

                switch (Program.menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Su saldo disponible es de: ");
                        Console.WriteLine();
                        Console.WriteLine("$" + SaldoyMovimientos.saldoDisponible);
                        Console.WriteLine();
                        Console.WriteLine("Presione tecla Enter para continuar.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Esta es su lista de ultimos movimientos:");
                        Console.WriteLine();
                        SaldoyMovimientos.Movimientos.ForEach(Console.WriteLine);
                        Console.WriteLine();
                        Console.WriteLine("Presione tecla Enter para continuar.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Su numero de CBU es el siguiente:");
                        Console.WriteLine();
                        Console.WriteLine("CBU nº: " + FormularioCreacionCuenta.CBU);
                        Console.WriteLine();
                        Console.WriteLine("Presione tecla Enter para continuar.");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
                Console.WriteLine("¿Desea realizar otra consulta?");
                Program.ask = "¿Desea realizar otra consulta?";
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                Program.menu = Console.ReadLine();
                Program.menu = Program.verificacion(Program.ask, Program.menu);

            } while (Program.menu == "1");
        }
    }
}
