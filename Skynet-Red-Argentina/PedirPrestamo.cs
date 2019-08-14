using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_Red_Argentina
{
    class PedirPrestamo
    {
        public static int prestamoMin = 200000, prestamosMax = 750000, valorPrestamo, cantCuotas;
        public static double tasa, valorCuota;
        public static string movimiento;

        public void pedirPrestamo()
        {
            Console.Clear();
            Console.WriteLine("Sr " + FormularioCreacionCuenta.apellido + " nos alegra informarle que usted tiene 1 (uno) prestamo inmediato pre-aprobado por un valor de $200000 en adelante (tope maximo de $750000)");
            Console.WriteLine();
            Console.WriteLine("¡Ahora con Red Argentina Skynet solicitar un prestamo nunca fue tan facil!");
            Console.WriteLine("¿Desea solicitar su prestamo ahora?");
            Program.ask = "¿Desea solicitar su prestamo ahora?";
            Console.WriteLine();
            Console.WriteLine("1 Si");
            Console.WriteLine("2 No");
            Program.menu = Console.ReadLine();
            Program.menu = Program.verificacion(Program.ask, Program.menu);

            if (Program.menu == "1")
            {
                Console.Clear();
                Console.WriteLine("Ingrese el valor de su prestamo. En este momento usted puede solicitar un monto minimamente de $" + prestamoMin + " hasta un maximo de $" + prestamosMax + "." );
                valorPrestamo = Convert.ToInt32(Console.ReadLine());

                while (valorPrestamo < 200000 || valorPrestamo > 750000)
                {
                    if (valorPrestamo < 200000)
                    {
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("El valor ingresado menor al minimo permitido ($" + prestamoMin + "). Intentelo nuevamente.");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el valor de su prestamo. En este momento usted puede solicitar un monto minimamente de $" + prestamoMin + " hasta un maximo de $" + prestamosMax + ".");
                        valorPrestamo = Convert.ToInt32(Console.ReadLine());
                    } else
                    {
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("El valor ingresado mayor al maximo permitido ($" + prestamosMax + "). Intentelo nuevamente.");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el valor de su prestamo. En este momento usted puede solicitar un monto minimamente de $" + prestamoMin + " hasta un maximo de $" + prestamosMax + ".");
                        valorPrestamo = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Clear();
                Console.WriteLine("Seleccione en cuantas cuotas desea abonar su prestamo.");
                Console.WriteLine();
                Console.WriteLine("1 12 Cuotas");
                Console.WriteLine("2 24 Cuotas");
                Console.WriteLine("3 36 Cuotas");
                Console.WriteLine("4 48 Cuotas");
                cantCuotas = Convert.ToInt32(Console.ReadLine());

                while (cantCuotas != 1 && cantCuotas != 2 && cantCuotas != 3 && cantCuotas != 4)
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("No selecciono una entrada valida.");
                    Console.WriteLine();
                    Console.WriteLine("Seleccione en cuantas cuotas desea abonar su prestamo.");
                    Console.WriteLine();
                    Console.WriteLine("1 12 Cuotas");
                    Console.WriteLine("2 24 Cuotas");
                    Console.WriteLine("3 36 Cuotas");
                    Console.WriteLine("4 48 Cuotas");
                    cantCuotas = Convert.ToInt32(Console.ReadLine());
                }

                switch (cantCuotas)
                {
                    case 1:
                        cantCuotas = 12;
                        tasa = 30;
                        break;
                    case 2:
                        cantCuotas = 24;
                        tasa = 40;
                        break;
                    case 3:
                        cantCuotas = 36;
                        tasa = 50;
                        break;
                    case 4:
                        cantCuotas = 48;
                        tasa = 60;
                        break;
                }

                Console.Clear();
                Console.WriteLine("Seleccione la cuenta a la que se acreditarán los pesos.");
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
                    Console.WriteLine("Seleccione la cuenta a la que se acreditarán los pesos.");
                    Console.WriteLine();
                    Console.WriteLine("1 " + Transferencias.CA);
                    Transferencias.cuenta = Console.ReadLine();
                }
                if (Transferencias.cuenta == "1" )
                {
                    Transferencias.cuenta = Transferencias.CA;
                }

                valorCuota = (valorPrestamo * tasa / 100 + valorPrestamo) / cantCuotas;
                valorCuota = Math.Round(valorCuota, 2);

                Console.Clear();
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

                Console.WriteLine("El plan de su prestamo fue calculado exitosamente");
                Console.WriteLine();
                Console.WriteLine("Prestamo solicitado por un valor de: $" + valorPrestamo + ".");
                Console.WriteLine("Cantidad de cuotas a abonar: " + cantCuotas + ".");
                Console.WriteLine("Monto de cuotas a abonar: $" + valorCuota + ".");
                Console.WriteLine("Tasa de interes aplicada: " + tasa + "%.");
                Console.WriteLine("Cuenta: " + Transferencias.cuenta + ".");
                Console.WriteLine();
                Console.WriteLine("¿Desea confirmar la operacion?");
                Program.ask = "¿Desea confirmar la operacion?";
                Console.WriteLine();
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                Program.menu = Console.ReadLine();
                Program.menu = Program.verificacion(Program.ask, Program.menu);

                if (Program.menu == "1")
                {
                    movimiento = "*** Entrante. A cuenta " + Transferencias.cuenta + ". Concepto: Prestamo Skynet a "+ cantCuotas + " meses, valor de cuota $" + valorCuota + ", tasa aplicada del " + tasa + "%.";
                    SaldoyMovimientos.Movimientos.Add(movimiento);
                    SaldoyMovimientos.saldoDisponible += valorPrestamo;

                    Console.Clear();
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

                    Console.WriteLine("Prestamo acreditado exitosamente. ¡Gracias por confiar en nosotros!");
                    Console.WriteLine("Se enviara la documentacion respaldatoria a su correspondiente direccion registrada: " + FormularioCreacionCuenta.direccion + ", " + FormularioCreacionCuenta.provincia + ", " + FormularioCreacionCuenta.ciudad + ".");

                    Console.WriteLine();
                    Console.WriteLine("Presione tecla Enter para continuar.");
                    Console.ReadLine();
                }
            }
        }
    }
}
