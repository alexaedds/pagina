using calcalex.Logica;

Calculadora calc=new();
Console.WriteLine("Ingrese N1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese N2");
int n2=int.Parse(Console.ReadLine());
Console.WriteLine("selecione :SUMAR S, RESTAR R, MULTIPLICAR M,DIVIDRI D");
string opcion=Console.ReadLine();
int res = 0; 
if (opcion.ToLower() == "s")
{
    res = calc.Sumar(n1, n2);
}
else if (opcion.ToLower() == "r")
{
    res = calc.Restar(n1, n2);
}
else if (opcion.ToLower() == "m")
{
    res = calc.Multiplicar(n1, n2);
}
else if (opcion.ToLower() == "d")
{
    res = calc.Dividir(n1, n2);
}

Console.WriteLine("respuesta "+res);