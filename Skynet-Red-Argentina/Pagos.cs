using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    class Pagos
    {
        string codigo, concepto, movimiento;
        double montoPago;

        public void pagos()
        {
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Mediante esta opcion usted podra realizar pagos desde sus cuentas a traves de la red PMC.");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese el codigo de referencia PMC. El mismo contiene 7 digitos y se encuentra al lado del codigo de barras.");
                    codigo = Console.ReadLine();

                    while (codigo.Length != 7)
                    {
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("El codigo ingresado no es valido.");
                        Console.WriteLine();
                        Console.WriteLine("Ingreselo nuevamente.");
                        codigo = Console.ReadLine();
                    }

                    Console.Clear();
                    Console.WriteLine("Ingrese el monto a abonar. Utilice el simbolo ',' para separar pesos de centavos.");
                    montoPago = Convert.ToDouble(Console.ReadLine());

                    while (montoPago <= 0)
                    {
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("El monto ingresado no es valido.");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el monto a abonar. Utilice el simbolo ',' para separar pesos de centavos.");
                        montoPago = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.Clear();
                    Console.WriteLine("Seleccione la cuenta desde la que abonará.");
                    Console.WriteLine();
                    Console.WriteLine("1 " + Transferencias.CA);
                    Transferencias.cuenta = Console.ReadLine();

                    Console.Clear();

                    while (Transferencias.cuenta != "1")
                    {
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("Por favor seleccione una opcion valida.");
                        Console.WriteLine();
                        Console.WriteLine("Seleccione la cuenta desde la que abonará.");
                        Console.WriteLine();
                        Console.WriteLine("1 " + Transferencias.CA);
                        Transferencias.cuenta = Console.ReadLine();
                    }

                    Console.Clear();
                    Console.WriteLine("Ingrese el concepto del pago.");
                    concepto = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Se van a abonar $" + montoPago);
                    Console.WriteLine("Desde su " + Transferencias.CA);
                    Console.WriteLine("El pago se realizara al codigo de referencia: " + codigo);
                    Console.WriteLine("El concepto del pago es: " + concepto);
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
                        Console.WriteLine("Se van a abonar $" + montoPago);
                        Console.WriteLine("Desde su " + Transferencias.CA);
                        Console.WriteLine("El pago se realizara al codigo de referencia: " + codigo);
                        Console.WriteLine("El concepto del pago es: " + concepto);
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
                    if (SaldoyMovimientos.saldoDisponible - montoPago >= 0)
                    {
                        movimiento = "***Pago. Desde " + Transferencias.CA + ". Codigo de pago: " + codigo + " Concepto: " + concepto + ". Monto: $" + montoPago + ".";
                        SaldoyMovimientos.Movimientos.Add(movimiento);
                        SaldoyMovimientos.saldoDisponible -= montoPago;
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
                    }
                    else
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
                Console.Clear();
                Console.WriteLine("¿Desea realizar otro pago?");
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                Program.menu = Console.ReadLine();

                while (Program.menu != "1" && Program.menu != "2")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                    Console.WriteLine();
                    Console.WriteLine("¿Desea realizar otro pago?");
                    Console.WriteLine("1 Si");
                    Console.WriteLine("2 No");
                    Program.menu = Console.ReadLine();
                }

            } while (Program.menu == "1");
        }
    }
}
