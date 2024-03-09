internal class Program
{
        public static void Main(string[] args)
    {
        double sueldoBase, venta1, venta2, venta3, MetaComision = 1000000;
        double totalcomision, TotalDevengo, promedio, comision1, comision2, comision3, totalventa;

        Console.Write("Ingrese sueldo base del empeleado ");
        Console.WriteLine();

        sueldoBase = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese venta 1 ");
        Console.WriteLine();

        venta1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese venta 2 ");
        Console.WriteLine();
        venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese venta 3 ");
        Console.WriteLine();
        venta3 = Convert.ToDouble(Console.ReadLine());

        totalventa = (venta1 + venta2 + venta3);

        comision1 = (venta1 * 0.10);
        comision2 = (venta2 * 0.10);
        comision3 = (venta3 * 0.10);

        totalcomision = (comision1 + comision2 + comision3);

        Console.Write($"Total comision es: {totalcomision.ToString("#,##0")}");
        Console.WriteLine();

        TotalDevengo = (sueldoBase + totalcomision);

        Console.Write($"Total Salario mas comision es de : {TotalDevengo.ToString("#,##0")}");
        Console.WriteLine();

        if ((comision1 > comision2) && (comision1 > comision3))

            Console.WriteLine($"La mas alta es: {comision1.ToString("#,##0")}");


        else if ((comision2 > comision3))

            Console.WriteLine($"La mas alta es: {comision2.ToString("#,##0")}");

        else
            Console.WriteLine($"La mas alta es: {comision3.ToString("#,##0")}");

        promedio = (comision1 + comision2 + comision3) / 3;

        Console.Write($"Total promedio : {promedio.ToString("#,##0")}");
        Console.WriteLine();


        if (totalventa == MetaComision)
        {
            Console.Write("El empleado gano el bono de 100,000 $ por superar la meta de las ventas");
            Console.WriteLine();
        }
    }

}