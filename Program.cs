double SalarioBruto, SalarioNeto = 0, TotalG, Ventas, Años, comision = 0, descuento = 0;
string nombre;

Console.Write("\nIngrese su nombre completo: ");
nombre = Console.ReadLine().ToUpper().Trim();
Console.Write("\nIngrese cuanto vendiste: ");
Ventas = Convert.ToDouble(Console.ReadLine());
Console.Write("\nIngrese su salario: ");
SalarioBruto = Convert.ToDouble(Console.ReadLine());
Console.Write("\nIngrese cuantos años llevas en la empresa: ");
Años = Convert.ToDouble(Console.ReadLine());

if (Ventas <= 600 && Ventas >= 0 )
{
    comision = Ventas + Ventas * 0.05;
}
else if (Ventas > 600 && Ventas <= 3000 )
{
    comision = Ventas + Ventas * 0.07;
}
else if (Ventas > 3000)
{
    comision = Ventas + Ventas * 0.06 + 300;
}

TotalG = SalarioBruto + comision;

if (Años > 0 && Años <= 3)
{
    descuento = TotalG * 0.65;
    SalarioNeto = TotalG - descuento;
}
if (Años > 4)
{
    descuento = TotalG * 0.45;
    SalarioNeto = TotalG - descuento;
}

Console.WriteLine("\n\nNombre: " + nombre);
Console.WriteLine("\nEl total que gano: " + TotalG);
Console.WriteLine("\nLa cantidad que se le descontara: " + descuento);
Console.WriteLine("\nEl total seria: " + SalarioNeto);



