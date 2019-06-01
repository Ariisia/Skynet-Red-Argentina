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
            string cuenta;
            Console.WriteLine("Bienvenido a la red Argentina de cajeros Skynet.");
            Console.WriteLine();
            Console.WriteLine("Para operar con esta terminal seleccione el numero de la opcion deseada y presione la tecla Enter.");
            Console.WriteLine();
            Console.WriteLine("¿Posee ya una cuenta Skynet?");
            Console.WriteLine("1 Si");
            Console.WriteLine("2 No");
            cuenta = Console.ReadLine();

            while (Convert.ToInt32(cuenta) != 1 && Convert.ToInt32(cuenta) != 2)
            {
                Console.WriteLine("Por favor seleccione una opcion valida.");
                Console.WriteLine("¿Posee ya una cuenta Skynet?");
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                cuenta = Console.ReadLine();
            }

            if (Convert.ToInt32(cuenta) == 2)
            {
                formulario.CrearCuenta();
            }
        }
    }
}
