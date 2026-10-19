namespace Calculadora_Basica
{
class Program
    {
        static int N1, N2, SUMA, RESTA, MULT, DIVISION;
        static string operacion;
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Iniciado");
            
            do{

            Console.WriteLine("\nIngrese el primer numero:");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la operacion a realizar (+, -, *, /, CE):");
            operacion = Console.ReadLine();
            Console.Clear();

            switch (operacion) 
            {
                case "+":
                    SUMAR(N1, N2);
                    break;
                case "-":
                    RESTAR();
                    break;
                case "*":
                    MULTIPLICAR();
                    break;
                case "/":
                    DIVIDIR();
                    break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }
            }while (operacion != "CE");

            Console.WriteLine("Programa terminado");
        }
        static void SUMAR(int N1, int N2)
        {
            SUMA = N1 + N2;
            Console.WriteLine($"RESULTADO:{SUMA}");
            return;
        }
        static void RESTAR()
        {
            RESTA = N1 - N2;
            Console.WriteLine($"RESULTADO:{RESTA}");
            return;
        }
        static void MULTIPLICAR()
        {
            MULT = N1 * N2;
            Console.WriteLine($"RESULTADO:{MULT}");
            return;
        }
        static void DIVIDIR()
        {
            if (N2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
                return;
            }
            else
            {
                DIVISION = N1 / N2;
                Console.WriteLine($"RESULTADO:{DIVISION}");
                return;
            }
        }
    }
}
