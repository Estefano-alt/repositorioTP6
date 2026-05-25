int opcion = 0;

do
{
    Console.WriteLine("\n===Seleccione una opcion===\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Propiedades de un numero\n6.Maximo y minimo\n7.Finalizar");

    string? s = Console.ReadLine();

    if (int.TryParse(s, out opcion))
    {
        if (opcion < 1 || opcion > 7)
        {
            Console.WriteLine("\nIngrese nuevamente. Opcion Invalida");
        }
        else
        {
            if (opcion == 7)
            {
                Console.WriteLine("\nPROGRAMA FINALIZADO");
                return;
            }

            int a, b, resultado = 0;

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("\nIngrese el primer numero:");
                    string? s1 = Console.ReadLine();

                    Console.WriteLine("\nIngrese el segundo numero:");
                    string? s2 = Console.ReadLine();

                    if (int.TryParse(s1, out a) && int.TryParse(s2, out b))
                    {
                        resultado = a + b;
                        Console.WriteLine("Suma de " + a + " + " + b + " = " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar numeros validos");
                    }

                    break;

                case 2:

                    Console.WriteLine("\nIngrese el primer numero:");
                    s1 = Console.ReadLine();

                    Console.WriteLine("\nIngrese el segundo numero:");
                    s2 = Console.ReadLine();

                    if (int.TryParse(s1, out a) && int.TryParse(s2, out b))
                    {
                        resultado = a - b;
                        Console.WriteLine("Resta de " + a + " - " + b + " = " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar numeros validos");
                    }

                    break;

                case 3:

                    Console.WriteLine("\nIngrese el primer numero:");
                    s1 = Console.ReadLine();

                    Console.WriteLine("\nIngrese el segundo numero:");
                    s2 = Console.ReadLine();

                    if (int.TryParse(s1, out a) && int.TryParse(s2, out b))
                    {
                        resultado = a * b;
                        Console.WriteLine("Producto de " + a + " * " + b + " = " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar numeros validos");
                    }

                    break;

                case 4:

                    Console.WriteLine("\nIngrese el primer numero:");
                    s1 = Console.ReadLine();

                    Console.WriteLine("\nIngrese el segundo numero:");
                    s2 = Console.ReadLine();

                    if (int.TryParse(s1, out a) && int.TryParse(s2, out b))
                    {
                        if (b != 0)
                        {
                            resultado = a / b;
                            Console.WriteLine("Division de " + a + " / " + b + " = " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("\nNo se puede dividir por 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar numeros validos");
                    }

                    break;

                case 5:
                    Console.WriteLine("\n====Seleccione una propiedad====");
                    Console.WriteLine("1.Valor absoluto");
                    Console.WriteLine("2.Cuadrado");
                    Console.WriteLine("3.Raiz cuadrada");
                    Console.WriteLine("4.Seno");
                    Console.WriteLine("5.Coseno");
                    Console.WriteLine("6.Parte entera");
                    int opcionPropiedad;

                    string? sp = Console.ReadLine();

                    if (int.TryParse(sp, out opcionPropiedad))
                    {
                        if (opcionPropiedad < 1 || opcionPropiedad > 6)
                        {
                            Console.WriteLine("\nOpcion invalida");
                        }
                        else
                        {
                            double c;
                            Console.WriteLine("\nIngrese un numero");
                            s1 = Console.ReadLine();
                            
                            // Verificar que la entrada sea un número válido
                            if (double.TryParse(s1, out c))
                            {
                                switch (opcionPropiedad)
                                {
                                    case 1: // Valor absoluto
                                        Console.WriteLine("Valor absoluto de " + c + " = " + Math.Abs(c));
                                        break;
                                    case 2: // Cuadrado
                                        Console.WriteLine("Cuadrado de " + c + " = " + (c * c));
                                        break;
                                    case 3: // Raíz cuadrada
                                        if (c >= 0)
                                            Console.WriteLine("Raíz cuadrada de " + c + " = " + Math.Sqrt(c));
                                        else
                                            Console.WriteLine("\nNo se puede calcular la raíz cuadrada de un número negativo");
                                        break;
                                    case 4: // Seno (en radianes)
                                        Console.WriteLine("Seno de " + c + " = " + Math.Sin(c));
                                        break;
                                    case 5: // Coseno (en radianes)
                                        Console.WriteLine("Coseno de " + c + " = " + Math.Cos(c));
                                        break;
                                    case 6: // Parte entera
                                        Console.WriteLine("Parte entera de " + c + " = " + Math.Truncate(c));
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nDebe ingresar un número válido");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar un numero");
                    }
                    break;

                case 6:

                    Console.WriteLine("\nIngrese el primer numero:");
                    s1 = Console.ReadLine();

                    Console.WriteLine("\nIngrese el segundo numero:");
                    s2 = Console.ReadLine();

                    // Parsear ambos números y mostrar máximo y mínimo
                    if (int.TryParse(s1, out a) && int.TryParse(s2, out b))
                    {
                        int maximo = Math.Max(a, b);
                        int minimo = Math.Min(a, b);
                        Console.WriteLine("El máximo es: " + maximo);
                        Console.WriteLine("El mínimo es: " + minimo);
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar números válidos");
                    }

                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("\nDato Invalido!!!.Ingrese nuevamente");
    }

} while (opcion != 7);