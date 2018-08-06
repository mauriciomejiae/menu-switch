using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_switch
{
    class Program
    {
        class Menu
        {
            static void Main(string[] args)
            {
                char opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("MENU");
                    Console.WriteLine("1) ejercicio 2");
                    Console.WriteLine("2) ejercicio 4");
                    Console.WriteLine("3) ejercicio 6");
                    Console.WriteLine("4) ejercicio 7");
                    Console.WriteLine("5) ejercicio 9");
                    Console.WriteLine("6) ejercicio 10 dias");
                    Console.WriteLine("7) ejercicio 10 reloj");
                    Console.WriteLine("8) Salir\n");
                    Console.Write("Seleccione una opcion: ");
                    do
                    {
                        opcion = Console.ReadKey(true).KeyChar;
                    } while (opcion < '1' || opcion > '8');
                    Console.WriteLine(opcion + "\n");
                    switch (opcion)
                    {
                        case '1':

                            int anno, anno_siguiente, dia, dia_siguiente, mes, mes_siguiente;
                            Console.Write("Ingrese el valor de anno: ");
                            anno = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de dia: ");
                            dia = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de mes: ");
                            mes = int.Parse(Console.ReadLine());
                            if ((dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || dia == 31 || (mes == 2 && (dia == 29 || (dia == 28 && (anno % 4 != 0 || anno % 100 == 0) && anno % 400 != 0))))
                            {
                                dia_siguiente = 1;
                                mes_siguiente = mes + 1;
                            }
                            else
                            {
                                dia_siguiente = dia + 1;
                                mes_siguiente = mes;
                            }
                            if (mes_siguiente == 13)
                            {
                                anno_siguiente = anno + 1;
                                mes_siguiente = 1;
                            }
                            else

                                Console.WriteLine("Valor de dia siguiente: " + dia_siguiente);
                            Console.WriteLine();
                            Console.Write("Presione una tecla para terminar . . . ");
                            Console.ReadKey();

                            break;
                        case '2':

                            int categoria;
                            double concepto_de_salud, horas_trabajadas, pago, pago_por_hora, salario_mensual, salario_total_devengado, subsidio;
                            Console.Write("Ingrese el valor de horas trabajadas: ");
                            horas_trabajadas = double.Parse(Console.ReadLine());
                            Console.WriteLine("Seleccione el valor de categoria.");
                            Console.WriteLine("\t1.- A1");
                            Console.WriteLine("\t2.- B2");
                            Console.WriteLine("\t3.- C3");
                            Console.WriteLine("\t4.- D4");
                            Console.Write("\t: ");
                            do
                            {
                                categoria = int.Parse(Console.ReadLine());
                                if (categoria < 1 || categoria > 4)
                                    Console.Write("Valor incorrecto. Ingr\u00E9selo nuevamente: ");
                            } while (categoria < 1 || categoria > 4);
                            pago_por_hora = 0;
                            if (categoria == 1)
                                pago_por_hora = 20000;
                            if (categoria == 2)
                                pago_por_hora = 15000;
                            if (categoria == 3)
                                pago_por_hora = 10000;
                            if (categoria == 4)
                                pago_por_hora = 7500;
                            salario_mensual = pago_por_hora * horas_trabajadas;
                            concepto_de_salud = salario_mensual * 0.072;
                            salario_total_devengado = salario_mensual - concepto_de_salud;
                            subsidio = concepto_de_salud < 1000000 ? salario_mensual * 0.15 : 0;
                            pago = salario_total_devengado - subsidio;
                            Console.WriteLine("Valor de concepto de salud: " + concepto_de_salud);
                            Console.WriteLine("Valor de pago: " + pago);
                            Console.WriteLine("Valor de pago por hora: " + pago_por_hora);
                            Console.WriteLine("Valor de salario mensual: " + salario_mensual);
                            Console.WriteLine("Valor de salario total devengado: " + salario_total_devengado);
                            Console.WriteLine("Valor de subsidio: " + subsidio);
                            Console.WriteLine();
                            Console.Write("Presione una tecla para terminar . . . ");
                            Console.ReadKey();

                            break;
                        case '3':


                            int i, numero;
                            Console.Write("Ingrese un numero:  ");
                            numero = int.Parse(Console.ReadLine());
                            for (i = 2; i < numero && numero % i != 0; i++) ;
                            if (i == numero)
                                Console.WriteLine("\n El numero  " + numero + " es primo.");
                            else
                                Console.WriteLine(" el numero  " + numero + "  no es primo.");
                            Console.Write("\n Presione una tecla para terminar ... ");
                            Console.ReadKey();

                            break;
                        case '4':


                            double lado_a, lado_b, lado_c;
                            Console.Write("Ingrese el valor de lado a: ");
                            lado_a = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de lado b: ");
                            lado_b = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de lado c: ");
                            lado_c = double.Parse(Console.ReadLine());
                            if (lado_a == lado_b && lado_b == lado_c)
                                Console.WriteLine("EQUILATERO");
                            if ((lado_a == lado_b && lado_b != lado_c) || (lado_b == lado_c && lado_c != lado_a) || (lado_c == lado_a && lado_a != lado_b))
                                Console.WriteLine("ISOSCELES");
                            if (lado_a != lado_b && lado_b != lado_c && lado_c != lado_a)
                                Console.WriteLine("ESCALENO");
                            Console.WriteLine();
                            Console.Write("Presione una tecla para terminar . . . ");
                            Console.ReadKey();

                            break;
                        case '5':


                            long num, bit;
                            Console.Write("Ingrese un numero entero positivo: ");
                            num = long.Parse(Console.ReadLine());
                            Console.Write("\n" + num + "=");
                            if (num == 0)
                                Console.Write(0);
                            for (bit = 1; bit <= num; bit *= 2) ;
                            for (bit /= 2; bit > 0; bit /= 2) ;
                            if (num >= bit)
                            {
                                Console.Write(1);
                                num -= bit;
                            }
                            else
                            {
                                Console.Write(0);
                            }
                            Console.Write("b\n\nPresione una tecla  para terminar ...");
                            Console.ReadKey();

                            break;
                        case '6':

                            int año, ddia, mmes;
                            Console.Write("Ingrese su año de nacimiento: ");
                            año = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese su dia de nacimiento: ");
                            ddia = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese su mes de nacimiento: ");
                            mmes = int.Parse(Console.ReadLine());

                            DateTime oldDate = new DateTime(año, mmes, ddia);
                            DateTime newDate = DateTime.Now;


                            TimeSpan ts = newDate - oldDate;


                            int differenceInDays = ts.Days;

                            System.Console.WriteLine("La cantidad de dias despues de su nacimiento son: {0} ", differenceInDays);
                            System.Console.ReadLine();
                            Console.Write("b\n\nPresione una tecla  para terminar ...");
                            Console.ReadKey();

                            Console.ReadKey();

                            break;



                        case '7':

                            Console.WriteLine("Simulacion de comportamiento de Reloj Digital:");

                            for (int h = 00; h <= 23; h++)
                            {
                                for (int m = 00; m <= 59; m++)
                                {
                                    for (int s = 00; s <= 59; s++)
                                    {
                                        Console.WriteLine(h + ":" + m + ":" + s);
                                    }
                                }
                            }
                            break;

                    }
                    if (opcion != '8')
                    {
                        Console.Write("\nPresione una tecla para continuar . . . ");
                        Console.ReadKey(true);
                    }
                } while (opcion != '8');
            }
        }
    }
}
