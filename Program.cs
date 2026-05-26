/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
/*
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
*/



Console.WriteLine("Ingrese una cadena de texto");
string? texto = Console.ReadLine();
if (texto != null)
{
    int longitud = texto.Length;
    Console.WriteLine("\nLongitud de la cadena: " + longitud);
}
Console.WriteLine("\nIngrese una segunda cadena de texto");
string? texto2 = Console.ReadLine();
if (texto != null && texto2 != null)
{
    // Concatenar cadenas
    string textoCompleto = texto + " " + texto2;
    Console.WriteLine("\nCadenas concatenadas: " + textoCompleto);
    // Subcadena
    string subcadena = texto.Substring(0, 3);
    Console.WriteLine("\nSubcadena: " + subcadena);
    foreach(char caracter in textoCompleto)
    {
        Console.WriteLine("\nCaracter: "+caracter);
    };
    Console.WriteLine("\nIngrese la palabra a buscar ");
    string? buscada = Console.ReadLine();
    int contador = 0;
    if(buscada != null)
    {
        string[] palabras = textoCompleto.Split(' ');
        foreach(string palabra in palabras)
        {
            if (buscada == palabra)
            {
                contador++;
            }
            
        }
        Console.WriteLine("\nOcurrencias: "+contador);
        Console.WriteLine("\nCadena completa MAYUS: "+ (textoCompleto.ToUpper()));
        Console.WriteLine("\nCadena completa MAYUS: "+ (textoCompleto.ToLower()));
    }
}

Console.WriteLine("\nIngrese una oracion usando como separador '/'");
string? texto3 = Console.ReadLine();
if(texto3 != null)
{
    string[] partes = texto3.Split("/");
    foreach(string parte in partes)
    {
        Console.WriteLine("Palabra: "+parte);
    }
}