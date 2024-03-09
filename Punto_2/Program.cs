//Punto 2:
//Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un
//segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad
//constante de 100 km/h. ¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora en
//pantalla

using System;

class Program
{
    static void Main(string[] args)
    {
        
        DateTime horaSalidaPrimerTren = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);

       
        DateTime horaSalidaSegundoTren = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0);

       
        double velocidadPrimerTren = 80;
        double velocidadSegundoTren = 100;

        
        TimeSpan tiempo = horaSalidaSegundoTren - horaSalidaPrimerTren;

        
        double distanciaRecorrida = velocidadPrimerTren * tiempo.TotalHours;

        
        DateTime horaAlcanzar = horaSalidaSegundoTren.AddHours(distanciaRecorrida / velocidadSegundoTren);

        
        Console.WriteLine("El segundo tren alcanzará al primer tren a las: " + horaAlcanzar.ToString("HH:mm"));
    }
}