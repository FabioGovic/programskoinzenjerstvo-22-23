using M.Modeli;
using M.T;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Termin terminalSmallTrain = new Termin(Trains.Velicina.Small);
            Termin terminalLargeTrain = new Termin(Trains.Velicina.Large);

            Employee employeeSmallTrain = new EmployeeBuil("Fabio").Build();
            Employee employeeLargeTrain = new EmployeeBuil("Ivan").SetSalary(0.11).Build();


            Vehicles car = new Vehicles(Vehicles.Type.Car, 40, 5);
            Vehicles van = new Vehicles(Vehicles.Type.Car, 8, 50);
            Vehicles bus = new Vehicles(Vehicles.Type.Bus, 20, 30);
            Vehicles truck = new Vehicles(Vehicles.Type.Truck, 5, 30);

            terminalSmallTrain.Park(car, employeeSmallTrain);
            terminalSmallTrain.Park(van, employeeSmallTrain);
            terminalLargeTrain.Park(bus, employeeLargeTrain);
            terminalLargeTrain.Park(truck, employeeLargeTrain);

            terminalSmallTrain.GetTicketEarnings();
            terminalLargeTrain.GetTicketEarnings();

            Console.WriteLine();

            employeeSmallTrain.GetEarnings();
            employeeLargeTrain.GetEarnings();

            Console.WriteLine();

            Test test = new Test();
            test.TestTrainSize();
        }
    }
}
