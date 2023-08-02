using System.Drawing;
int numero = 0;
bool prim = true;
Console.WriteLine("Escriba el numero");
numero = int.Parse(Console.ReadLine());
for (int i = 2; i < numero; i++)
{
    if(numero % i == 0)
    {
        prim = false;
    }
}
Console.WriteLine("el valor es " + numero);

if(prim)
{
    Console.WriteLine("el numero es primo");
}
else
{
    Console.WriteLine("el numero no es primo");
}
