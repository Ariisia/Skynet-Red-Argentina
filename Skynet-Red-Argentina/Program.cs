using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    class Program
    {
        static void Main(string[] args)
        {
            FormularioCreacionCuenta formulario = new FormularioCreacionCuenta();
            Logueo logueo = new Logueo();
            Consultas consultas = new Consultas();
            Transferencias transferencias = new Transferencias();
            GeneracionDeClaves generacion = new GeneracionDeClaves();
            string cuenta, menu;

            Console.WriteLine("Bienvenido a la red Argentina de cajeros Skynet.");
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

            Console.WriteLine("Seleccione la operacion que desea realizar.");
            Console.WriteLine("1 Consultas");
            Console.WriteLine("2 Transferencias");
            Console.WriteLine("3 Generación de clave");
            Console.WriteLine("4 Pagos");
            Console.WriteLine("5 Solicitar Mi Prestamo Skynet");
            menu = Console.ReadLine();

            while (menu != "1" && menu != "2" && menu != "3" && menu != "4" && menu != "5")
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("Por favor seleccione una opcion valida.");
                Console.WriteLine();
                Console.WriteLine("Seleccione la operacion que desea realizar.");
                Console.WriteLine("1 Consultas");
                Console.WriteLine("2 Transferencias");
                Console.WriteLine("3 Generación de clave");
                Console.WriteLine("4 Pagos");
                Console.WriteLine("5 Solicitar Mi Prestamo Skynet");
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

                    break;
                case "5":

                    break;
            }
        }
    }
}
