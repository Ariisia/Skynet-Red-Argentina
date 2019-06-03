using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    public class FormularioCreacionCuenta
    {
        public static string nombre = "Agustín", apellido = "Rivas", docTipo, docNumero = "", direccion, provincia, ciudad, usuario = "Agustin", contraseña = "Rivas", verificacion, CBU = "0190154660000004982031";
        public static int usuarioLenght, contraseñaLenght;

        public void CrearCuenta()
        {
            Console.Clear();

            Console.WriteLine("A continuación debera crear su cuenta Skynet.");

            Console.Clear();

            Console.WriteLine("Ingrese su nombre.");
            nombre = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ingrese su apellido.");
            apellido = Console.ReadLine();

            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Seleccione el tipo documento:");
            Console.WriteLine();
            Console.WriteLine("1 DNI");
            Console.WriteLine("2 Cedula de Identidad");
            Console.WriteLine("3 Libreta de Enrolamiento");
            Console.WriteLine("4 Libreta Cívica");
            Program.menu = Console.ReadLine();

            Console.Clear();

            while (Program.menu != "1" && Program.menu != "2" && Program.menu != "3" && Program.menu != "4")
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("No selecciono una entrada valida.");
                Console.WriteLine();
                Console.WriteLine("Seleccione el tipo documento:");
                Console.WriteLine();
                Console.WriteLine("1 DNI");
                Console.WriteLine("2 Cedula de Identidad");
                Console.WriteLine("3 Libreta de Enrolamiento");
                Console.WriteLine("4 Libreta Cívica");
                Program.menu = Console.ReadLine();
            }
            Console.Clear();

            switch (Program.menu)
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

            Console.WriteLine();

            Console.WriteLine("Indique su provincia.");
            provincia = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Indique su ciudad");
            ciudad = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese su nuevo usuario. El mismo debera poseer al menos 8 caracteres.");
            usuario = Console.ReadLine();
            usuarioLenght = usuario.Length;

            Console.Clear();

            while (usuarioLenght < 8)
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("El usuario ingresado posee menos de 8 caracteres.");
                Console.WriteLine();
                Console.WriteLine("Ingrese su nuevo usuario. El mismo debera poseer al menos 8 caracteres.");
                usuario = Console.ReadLine();
                usuarioLenght = usuario.Length;
            }

            Console.Clear();

            Console.WriteLine("Ingrese su nueva contraseña. La misma debera poseer al menos 4 caracteres.");
            contraseña = Console.ReadLine();
            contraseñaLenght = contraseña.Length;

            Console.Clear();

            while (contraseñaLenght < 4)
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("La contraseña ingresada posee menos de 4 caracteres.");
                Console.WriteLine();
                Console.WriteLine("Ingrese su nueva contraseña. La misma debera poseer al menos 4 caracteres.");
                contraseña = Console.ReadLine();
                contraseñaLenght = contraseña.Length;
            }


            Console.WriteLine("Repita su nueva contraseña.");
            verificacion = Console.ReadLine();

            Console.Clear();

            while (contraseña != verificacion)
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("Las contraseñas no coinciden, intentelo de nuevo.");
                Console.WriteLine("Ingrese su nueva contraseña.");
                contraseña = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Repita su nueva contraseña.");
                verificacion = Console.ReadLine();
            }

            Console.Clear();

            
            Console.WriteLine("Su cuenta ha sido creada exitosamente.");
            Console.WriteLine("Se ha vinculado esta cuenta con su Caja de ahorros en Banco Skynet CBU: "+ CBU +" , presione tecla Enter para continuar.");
            Console.WriteLine("Puede revisar su saldo disponible en la opcion de Consultas. Para continuar presione tecla Enter.");
            Console.ReadLine();
        }
    }
}
