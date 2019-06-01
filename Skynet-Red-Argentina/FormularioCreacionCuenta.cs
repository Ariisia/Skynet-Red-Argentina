using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    public class FormularioCreacionCuenta
    {

        public static string nombre, apellido, docNTipo, docTipo = "", docNumero = "", direccion, provincia, ciudad, usuario, contraseña, verificacion;
        

        public void CrearCuenta()
        {
            Console.Clear();

            Console.WriteLine("A continuación debera crear su cuenta Skynet.");

            Console.Clear();

            Console.WriteLine("Ingrese su nombre.");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido.");
            apellido = Console.ReadLine();

            Console.WriteLine("Seleccione el tipo documento:");
            Console.WriteLine("1 DNI");
            Console.WriteLine("2 Cedula de Identidad");
            Console.WriteLine("3 Libreta de Enrolamiento");
            Console.WriteLine("4 Libreta Cívica");
            docNTipo = Console.ReadLine();

            Console.Clear();

            while (docNTipo != "1" && docNTipo != "2" && docNTipo != "3" && docNTipo != "4")
            {
                Console.WriteLine("No selecciono una entrada valida.");
                Console.WriteLine("Seleccione el tipo documento:");
                Console.WriteLine("1 DNI");
                Console.WriteLine("2 Cedula de Identidad");
                Console.WriteLine("3 Libreta de Enrolamiento");
                Console.WriteLine("4 Libreta Cívica");
                docNTipo = Console.ReadLine();
            }
            Console.Clear();

            switch (docNTipo)
            {
                case "1":
                    Console.WriteLine("Ingrese su numero de DNI");
                    docTipo = "DNI";
                    docNumero = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Ingrese su numero de Cedula de Identidad");
                    docNumero = Console.ReadLine();
                    docTipo = "Cedula de Identidad";
                    break;
                case "3":
                    Console.WriteLine("Ingrese su numero de Libreta de Enrolamiento");
                    docNumero = Console.ReadLine();
                    docTipo = "Libreta de Enrolamiento";
                    break;
                case "4":
                    Console.WriteLine("Ingrese su numero de Libreta Cívica");
                    docNumero = Console.ReadLine();
                    docTipo = "Libreta Cívica";
                    break;
            }
            Console.Clear();

            Console.WriteLine("Indique su direccion, numero, depto y piso (si fuera necesario).");
            direccion = Console.ReadLine();

            Console.WriteLine("Indique su provincia.");
            provincia = Console.ReadLine();

            Console.WriteLine("Indique su ciudad");
            ciudad = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese su nuevo usuario.");
            usuario = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ingrese su nueva contraseña.");
            contraseña = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Repita su nueva contraseña.");
            verificacion = Console.ReadLine();

            Console.Clear();

            while (contraseña != verificacion)
            {
                Console.Clear();
                Console.WriteLine("Las contraseñas no coinciden, intentelo de nuevo.");
                Console.WriteLine("Ingrese su nueva contraseña.");
                contraseña = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Repita su nueva contraseña.");
                verificacion = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("Su cuenta ha sido creada exitosamente, presione tecla Enter para continuar.");
            Console.ReadLine();
        }
    }
}
