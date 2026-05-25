/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/



int opcion = 0;

do
{
    Console.WriteLine("\n===Seleccione una opcion===\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Finalizar");
    string? s = Console.ReadLine();

    if (int.TryParse(s, out opcion))
    {
        if (opcion < 1 || opcion > 5)
        {
            Console.WriteLine("\nIngrese nuevamente. Opcion Invalida");
        }
        else
        {
            if (opcion == 5)
            {
                Console.WriteLine("\nPROGRAMA FINALIZADO");
                return;
            }

            int a, b, resultado = 0;

            Console.WriteLine("\nIngrese el primer numero:");
            string? s1 = Console.ReadLine();

            Console.WriteLine("\nIngrese el segundo numero:");
            string? s2 = Console.ReadLine();

            if (int.TryParse(s1, out a) && int.TryParse(s2, out b))
            {
                switch (opcion)
                {
                    case 1:
                        resultado = a + b;
                        Console.WriteLine("Suma de " + a + " + " + b + " = " + resultado);
                        break;

                    case 2:
                        resultado = a - b;
                        Console.WriteLine("Resta de " + a + " - " + b + " = " + resultado);
                        break;

                    case 3:
                        resultado = a * b;
                        Console.WriteLine("Producto de " + a + " * " + b + " = " + resultado);
                        break;

                    case 4:
                        if (b != 0)
                        {
                            resultado = a / b;
                            Console.WriteLine("Division de " + a + " / " + b + " = " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("\nNo se puede dividir por 0");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nDebe ingresar numeros validos");
            }
        }
    }
    else
    {
        Console.WriteLine("\nDato Invalido!!!.Ingrese nuevamente");
    }

} while (opcion!=5);