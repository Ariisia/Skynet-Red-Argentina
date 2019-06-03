using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Skynet_Red_Argentina
{
    public class Program
    {
        public static string cuenta, menu;

        static void Main(string[] args)
        {
            SpeechSynthesizer Hablar = new SpeechSynthesizer();
            FormularioCreacionCuenta formulario = new FormularioCreacionCuenta();
            Logueo logueo = new Logueo();
            Consultas consultas = new Consultas();
            Transferencias transferencias = new Transferencias();
            GeneracionDeClaves generacion = new GeneracionDeClaves();
            Pagos pagos = new Pagos();
            PedirPrestamo prestamo = new PedirPrestamo();

            Console.WriteLine("Bienvenido a la Red Argentina de cajeros Skynet.");
            Hablar.Speak("Bienvenido a la Red Argentina de cajeros Skainet.");
            Console.WriteLine();
            Console.WriteLine("Para operar con esta terminal seleccione el numero de la opcion deseada y presione tecla Enter.");
            Console.WriteLine();
            Console.WriteLine("¿Posee ya una cuenta Skynet?");
            Console.WriteLine("1 Si");
            Console.WriteLine("2 No");
            cuenta = Console.ReadLine();

            while (cuenta != "1" && cuenta != "2")
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("Por favor seleccione una opcion valida.");
                Console.WriteLine();
                Console.WriteLine("¿Posee ya una cuenta Skynet?");
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                cuenta = Console.ReadLine();
            }

            if (Convert.ToInt32(cuenta) == 2)
            {
                formulario.CrearCuenta();
            }

            logueo.logueo();

            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione la operacion que desea realizar.");
                Console.WriteLine();
                Console.WriteLine("1 Consultas");
                Console.WriteLine("2 Transferencias");
                Console.WriteLine("3 Generación de clave");
                Console.WriteLine("4 Pagos");
                Console.WriteLine("5 Solicitar Mi Prestamo Skynet");
                Console.WriteLine("6 Salir de este menu");
                menu = Console.ReadLine();

                while (menu != "1" && menu != "2" && menu != "3" && menu != "4" && menu != "5" && menu != "6")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                    Console.WriteLine();
                    Console.WriteLine("Seleccione la operacion que desea realizar.");
                    Console.WriteLine();
                    Console.WriteLine("1 Consultas");
                    Console.WriteLine("2 Transferencias");
                    Console.WriteLine("3 Generación de clave");
                    Console.WriteLine("4 Pagos");
                    Console.WriteLine("5 Solicitar Mi Prestamo Skynet");
                    Console.WriteLine("6 Salir de este menu");
                    menu = Console.ReadLine();
                }

                switch (menu)
                {
                    case "1":
                        consultas.consultas();
                        break;
                    case "2":
                        transferencias.transferencias();
                        break;
                    case "3":
                        generacion.generacionDeClaves();
                        break;
                    case "4":
                        pagos.pagos();
                        break;
                    case "5":
                        prestamo.pedirPrestamo();
                        break;
                    default:
                        break;
                }

                Console.Clear();
                Console.WriteLine("¿Desea realizar otra operacion?");
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                menu = Console.ReadLine();

                while (menu != "1" && menu != "2")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                    Console.WriteLine();
                    Console.WriteLine("¿Desea realizar otra operacion?");
                    Console.WriteLine("1 Si");
                    Console.WriteLine("2 No");
                    menu = Console.ReadLine();
                }

            } while (menu == "1");

            Console.Clear();
            Console.WriteLine("Muchas gracias por utilizar la Red Argentina de cajeros Skynet.");
            Hablar.Speak("Muchas gracias por utilizar la Red Argentina de cajeros Skainet.");
        }
    }
}
