/*
Escribe un programa que muestre por consola (con un print) los números de 1 a 100 (ambos incluidos y con un salto de línea entre cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 *
 */



for (int i = 1; i < 101; i++)
{
    int r=3;
    int p=5;
    int k=i%p;
    int j=i%r;
    if (j==0 && k==0)
    {
        Console.WriteLine("fizz, buzz");
    }
    else if (k==0)
    {
        Console.WriteLine("buzz");
    }
    else if(j==0)
    {
        Console.WriteLine("fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
    
}
