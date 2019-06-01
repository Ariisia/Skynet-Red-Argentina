using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    public class Logueo
    {
        public void logueo()
        {
            string veriUsuario, veriContraseña;
            int contlogin = 3;

            Console.Clear();

            Console.WriteLine("Para continuar debera ingresar al sistema a continuacion");
            Console.WriteLine();

            Console.WriteLine("Ingrese su usuario.");
            veriUsuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña.");
            veriContraseña = Console.ReadLine();

            Console.Clear();

            while (veriUsuario != FormularioCreacionCuenta.usuario || veriContraseña != FormularioCreacionCuenta.contraseña)
            {
                contlogin -= 1;

                if (contlogin == 0)
                {
                    return;
                }

                Console.Clear();
                Console.WriteLine("Usuario o contraseña incorrectos. Tiene " + contlogin + " intentos restantes.");
                Console.WriteLine();

                Console.WriteLine("Ingrese su usuario.");
                veriUsuario = Console.ReadLine();

                Console.WriteLine("Ingrese su contraseña.");
                veriContraseña = Console.ReadLine();

            }

            Console.Clear();

            Console.WriteLine("Ha ingresado al sistema correctamente.");
            Console.WriteLine("Bienvenido Sr " + FormularioCreacionCuenta.apellido + ", para continuar presione tecla Enter");
            Console.ReadLine();
        }
    }
}
