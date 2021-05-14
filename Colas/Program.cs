using Colas.clases.ColaArreglo;
using Colas.clases.Pila_Lista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Program
    {
        private static bool valido(string numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }

        public static void Capicua()
        {
            //programa capicua
            bool capicua;
            string numero;

            PilaLista pila = new PilaLista();
            ColaCircular circula_Cola = new ColaCircular();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\n Teclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la capicua cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        pila.insertar(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)circula_Cola.quitar();
                        capicua = d.Equals(pila.quitar()); //compara la igualdad
                    } while (capicua && !circula_Cola.colaVacia());

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message} ");
            }

            Console.ReadKey();
        
        }

        public static void CapicuaStack()
        {
            bool capicua;
            string numero;

            //mandando a llamar la clase de pila lineal para usar stack
            PilaLineal pila = new PilaLineal();
            ColaCircular circula_Cola = new ColaCircular();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\n Teclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la capicua cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        //se cambio el tipo de dato char a int
                        int c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        pila.insertar(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        //igual que aca se cambio char por int
                        int d;
                        d = (int)circula_Cola.quitar();
                        capicua = d.Equals(pila.quitar()); //compara la igualdad
                    } while (capicua && !circula_Cola.colaVacia());

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message} ");
            }

            Console.ReadKey();

        }
        
        //mandando a llamar las librerias de Queue
        static Queue qt = new Queue();
        public static void CapicuaQueue()
        {
            bool capicua;
            string numero;           

            ColaCircular circula_Cola = new ColaCircular();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\n Teclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la capicua cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        //se esta insertando el numero en la cola
                        qt.Enqueue(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        //se esta retirando de la cola 
                        d = (char)qt.Dequeue();
                        capicua = d.Equals(qt.Dequeue()); //compara la igualdad
                    } while (capicua && !IsEmpty()); //se evalua capicua y la diferencia con el metodo para el contador vacio

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message} ");
            }

            Console.ReadKey();

        }

        //cree este metodo para que me devolviera si el contador esta vacio
        public static bool IsEmpty()
        {
            return qt.Count == 0;
        }

        static void Main(string[] args)
        {
        }
    }
}
