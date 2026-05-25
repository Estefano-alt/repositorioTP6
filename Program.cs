/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
Console.WriteLine("\nIngrese un numero mayor a 0");

string s;
s = Console.ReadLine();

int numero;
int invertido=0;
int resto;
if (int.TryParse(s, out numero))
{
    if (numero <= 0)
    {
        Console.WriteLine("\nEs un numero invalido");
    }
    else
    {
        Console.WriteLine("\nEl numero "+numero+" es valido");
        while (numero > 0)
        {
            resto = numero%10;
            numero = numero/10;
            invertido = invertido*10 + resto;
        }
        Console.WriteLine("\nNumero invertido: "+invertido);
    }
    
}
else
{
    Console.WriteLine("\nNo es un numero");
}