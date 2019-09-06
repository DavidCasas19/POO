using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1._Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            RepoVehiculo v = new RepoVehiculo();
            v.Mostrarvehiculo(v);
         

            Console.WriteLine("Lista de los vehiculos");
            Console.ReadKey();
            v.ListadeVehiculos(v);


            vehiculo VehiculoA = new vehiculo();


            VehiculoA.Id=10;
            VehiculoA.nombre = "Pilot";
            VehiculoA.anio = 2000;
            VehiculoA.marca = "Honda";
            VehiculoA.tipo = "Todo terreno";

            vehiculo VehiculoB = new vehiculo();


            VehiculoB.Id = 11;
            VehiculoB.nombre = "Ford fiesta";
            VehiculoB.anio = 2007;
            VehiculoB.marca = "Ford";
            VehiculoB.tipo = "Todo terreno";

            vehiculo VehiculoC = new vehiculo();


            VehiculoC.Id = 12;
            VehiculoC.nombre = "Honda Accord";
            VehiculoC.anio = 2010;
            VehiculoC.marca = "Honda";
            VehiculoC.tipo = "Sedan";

            vehiculo VehiculoD = new vehiculo();


            VehiculoD.Id = 13;
            VehiculoD.nombre = "Lobo";
            VehiculoD.anio = 2014;
            VehiculoD.marca = "Ford";
            VehiculoD.tipo = "Camioneta";

            vehiculo VehiculoE = new vehiculo();


            VehiculoE.Id = 14;
            VehiculoE.nombre = "Honda Civic";
            VehiculoE.anio = 2009;
            VehiculoE.marca = "Honda";
            VehiculoE.tipo = "Sedan";




            Console.WriteLine(VehiculoA.nombre + "-" + VehiculoA.marca + "-" + VehiculoA.anio + "-" + VehiculoA.tipo);

            Console.WriteLine(VehiculoB.nombre + "-" + VehiculoB.marca + "-" + VehiculoB.anio + "-" + VehiculoB.tipo);

            Console.WriteLine(VehiculoC.nombre + "-" + VehiculoC.marca + "-" + VehiculoC.anio + "-" + VehiculoC.tipo);

            Console.WriteLine(VehiculoD.nombre + "-" + VehiculoD.marca + "-" + VehiculoD.anio + "-" + VehiculoD.tipo);

            Console.WriteLine(VehiculoE.nombre + "-" + VehiculoE.marca + "-" + VehiculoE.anio + "-" + VehiculoE.tipo);
        }
    }
}
