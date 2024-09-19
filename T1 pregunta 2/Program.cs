int placa = 0, contador = 1;
string color;

Console.WriteLine("Ingrese Los colores de la calcamia que llevaban los autos que pasaron");


while (contador >= 1)
{ 
    
    color = Console.ReadLine().ToUpper().Trim();

    if (color == "VERDE")
    {
        contador += 1;
        for (placa += 1; placa <= 3 && placa >= 0;) { placa += 1; }     
    }
    else if (color == "AZUL")
    {
        contador += 1;
        for (placa += 1; placa <= 6 && placa > 3;) { placa += 1; }
    }
    else if (color == "ROJO")
    {
        contador += 1;
        for (placa += 1; placa <= 9 && placa > 6;) { placa += 1; }
    }
    else if (color == "F")
    {
        contador -= 1;
        
        Console.WriteLine($"{placa}, "); 
        
        break;
    }
    
}
