using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    class Transferencias
    {
        double  transfSaliente;
        public static string movimiento, nombreTransf, apellidoTransf, cbuDestino, cuenta, CA = "Caja de ahorro en pesos Nº 141 324565/6";

        public void transferencias()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el destino de la transferencia.");
                Console.WriteLine("1 Ingresar CBU");
                Console.WriteLine("2 Seleccionar destino de la agenda");
                Program.menu = Console.ReadLine();

                while (Program.menu != "1" && Program.menu != "2")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese el destino de la transferencia.");
                    Console.WriteLine("1 Ingresar CBU");
                    Console.WriteLine("2 Seleccionar destino de la agenda");
                    Program.menu = Console.ReadLine();
                }

                if (Program.menu == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Usted no posee contactos en su agenda aun, los mismos deberan ser agregados desde nuestro Homebanking en https://www.Skynet.com.ar.");
                    Console.WriteLine("Presione tecla Enter para continuar.");
                    Console.ReadLine();
                    
                } else {
                    do {
                        Console.Clear();
                        Console.WriteLine("Ingrese el CBU del destinatario.");
                        cbuDestino = Console.ReadLine();

                        while (cbuDestino.Length != 22)
                        {
                            Console.Beep();
                            Console.Clear();
                            Console.WriteLine("Se ha ingresado un CBU incorrecto.");
                            Console.WriteLine();
                            Console.WriteLine("Ingrese el CBU del destinatario.");
                            cbuDestino = Console.ReadLine();
                        }

                        Console.Clear();

                        Console.WriteLine("Ingrese el Nombre del destinatario.");
                        nombreTransf = Console.ReadLine();
                       Console.WriteLine("Ingrese el Apellido del destinatario.");
                        apellidoTransf = Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("Seleccione la cuenta desde la que desea transferir.");
                        Console.WriteLine();
                        Console.WriteLine("1 " + CA );
                        cuenta = Console.ReadLine();

                        Console.Clear();

                    while(cuenta != "1")
                    {
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("Por favor seleccione una opcion valida.");
                        Console.WriteLine();
                        Console.WriteLine("Seleccione la cuenta desde la que desea transferir.");
                        Console.WriteLine();
                        Console.WriteLine("1 " + CA);
                        cuenta = Console.ReadLine();
                        }
                        if (Transferencias.cuenta == "1")
                        {
                            Transferencias.cuenta = Transferencias.CA;
                        }
                        Console.Clear();

                        Console.WriteLine("Ingrese el monto que desea transferir. Utiliza el simbolo ',' para separar los pesos de los centavos.");
                        transfSaliente = Convert.ToDouble(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("Se van a transferir: $" + transfSaliente);
                        Console.WriteLine("Desde su " + Transferencias.cuenta);
                        Console.WriteLine("El destinatario es: " + apellidoTransf + " " + nombreTransf + ".");
                        Console.WriteLine("CBU Nº: " + cbuDestino);
                        Console.WriteLine();
                        Console.WriteLine("Revise que los datos sean correctos");
                        Console.WriteLine();
                        Console.WriteLine("¿Confirma operacion?");
                        Console.WriteLine("1 Si");
                        Console.WriteLine("2 No");
                        Console.WriteLine("3 Salir sin realizar ninguna operacion");
                        Program.menu = Console.ReadLine();

                        Console.Clear();

                        while (Program.menu != "1" && Program.menu != "2" && Program.menu != "3")
                        {
                            Console.Beep();
                            Console.Clear();
                            Console.WriteLine("Por favor seleccione una opcion valida.");
                            Console.WriteLine();
                            Console.WriteLine("Se van a transferir: $" + transfSaliente);
                            Console.WriteLine("Desde su " + CA);
                            Console.WriteLine("El destinatario es: " + apellidoTransf + " " + nombreTransf + ".");
                            Console.WriteLine("CBU Nº: " + cbuDestino);
                            Console.WriteLine();
                            Console.WriteLine("Revise que los datos sean correctos");
                            Console.WriteLine();
                            Console.WriteLine("¿Confirma operacion?");
                            Console.WriteLine("1 Si");
                            Console.WriteLine("2 No");
                            Console.WriteLine("3 Salir sin realizar ninguna operacion");
                            Program.menu = Console.ReadLine();
                        } 
                    } while (Program.menu == "2");

                    Console.Clear();

                    if (Program.menu == "1")
                    {
                        if (SaldoyMovimientos.saldoDisponible - transfSaliente >= 0)
                        {
                            movimiento = "*** Saliente. Desde " + CA + " a CBU Nº " + cbuDestino + ". Destinatario: " + apellidoTransf + " " + nombreTransf + " . Monto: $" + transfSaliente + ".";
                            SaldoyMovimientos.Movimientos.Add(movimiento);
                            SaldoyMovimientos.saldoDisponible -= transfSaliente;
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine(".");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine(". .");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine(". . .");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            Console.WriteLine("La operacion se realizo exitosamente. Presione tecla Enter para continuar.");
                            Console.ReadLine();
                        } else
                        {
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            Console.WriteLine(".");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            Console.WriteLine(". .");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            Console.WriteLine(". . .");
                            System.Threading.Thread.Sleep(1500);
                            Console.Beep();
                            Console.Clear();
                            Console.WriteLine("No cuenta con saldo suficiente para realizar esta operacion.");
                            Console.WriteLine();
                            Console.WriteLine("Presione tecla Enter para continuar.");
                            Console.ReadLine();
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("¿Desea realizar otra transferencia?");
                Program.ask = "¿Desea realizar otra transferencia?";
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                Program.menu = Console.ReadLine();
                Program.menu = Program.verificacion(Program.ask, Program.menu);

            } while (Program.menu == "1");
        }
    }
}
