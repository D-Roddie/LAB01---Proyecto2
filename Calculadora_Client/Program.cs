

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Calculadora_Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MostarMenu();
        }


        private static void MostarMenu()
        {
            var opcion = -1;

            while (opcion != 5)
            {
                Console.WriteLine();
                Console.WriteLine("***CALCÚLADORA***");
                Console.WriteLine();
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.WriteLine();
                Console.Write("Digite el número de la operación que desea realizar: ");
                Console.WriteLine();
                opcion = int.Parse(Console.ReadLine());
                ProcesarOpcion(opcion);
            }
        }

        private static void ProcesarOpcion(int pOpcion)
        {
            switch (pOpcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    Restar();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("ERROR: Opción Invalida");
                    break;
            }
        }


        private static async Task RunAsync(Operacion op)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://calculadoraapi20180918082300.azurewebsites.net/");
                HttpResponseMessage response;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                response = await client.PostAsJsonAsync("api/Calculadora", op);
                var accion = await response.Content.ReadAsAsync<Operacion>();
                Console.WriteLine("Resultado: " + accion.resultado);
            }
        }


        private static void Sumar()
        {
            var tipoOp = "Suma";
            int numA;
            int numB;

            Console.WriteLine();
            Console.Write("Digite el valor del primer número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite el valor del segundo número: ");
            numB = int.Parse(Console.ReadLine());


            var auxOP = new Operacion(tipoOp, numA, numB);
            Console.WriteLine();
            RunAsync(auxOP).Wait();
        }

        private static void Restar()
        {
            var tipoOp = "Resta";
            int numA;
            int numB;

            Console.WriteLine();
            Console.Write("Digite el valor del primer número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite el valor del segundo número: ");
            numB = int.Parse(Console.ReadLine());


            var auxOP = new Operacion(tipoOp, numA, numB);
            Console.WriteLine();
            RunAsync(auxOP).Wait();
        }

        private static void Multiplicar()
        {
            var tipoOp = "Multiplicacion";
            int numA;
            int numB;

            Console.WriteLine();
            Console.Write("Digite el valor del primer número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite el valor del segundo número: ");
            numB = int.Parse(Console.ReadLine());


            var auxOP = new Operacion(tipoOp, numA, numB);
            Console.WriteLine();
            RunAsync(auxOP).Wait();
        }

        private static void Dividir()
        {
            var tipoOp = "Division";
            int numA;
            int numB;

            Console.WriteLine();
            Console.Write("Digite el valor del primer número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite el valor del segundo número: ");
            numB = int.Parse(Console.ReadLine());


            var auxOP = new Operacion(tipoOp, numA, numB);
            Console.WriteLine();
            RunAsync(auxOP).Wait();
        }
    }
}