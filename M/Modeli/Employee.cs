using M.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Modeli
{
    public class Employee : IRecharge
    {
        private string name;
        private double salary;
        private double earnings;

        public double Salary { get => salary; set => salary = value; }

        public Employee(string name)
        {
            this.name = name;
            this.salary = 0.1;
        }

        public void Check(Vehicles vehicle, Trains train)
        {
            if (train.GetCapacity() > 0)
            {
                train.SetCapacity();
                earnings += vehicle.GetFare() * Salary;

                if (vehicle.GetvelicinaRez() < Konst.NAJMANJA)
                {
                    Console.WriteLine(name + "'s " + vehicle.GetVrsta().ToString() + " gas size is " + vehicle.GetvelicinaRez() + "% full");
                    Console.WriteLine("Gas is refilling...");
                    vehicle.SetvelicinaRez();
                    Console.WriteLine(name + "'s " + vehicle.GetVrsta().ToString() + " gas size is " + vehicle.GetvelicinaRez() + "% full");
                }

                if (vehicle.GetvelicinaBat() < Konst.NAJMANJA)
                {
                    Console.WriteLine(name + "'s " + vehicle.GetVrsta().ToString() + " battery size is " + vehicle.GetvelicinaBat() + "% full");
                    Console.WriteLine("Battery is refilling...");
                    vehicle.SetvelicinaBat();
                    Console.WriteLine(name + "'s " + vehicle.GetVrsta().ToString() + " battery size is " + vehicle.GetvelicinaBat() + "% full");

                }
            }
        }

        public string GetName() => name;

        public void GetEarnings() =>
            Console.WriteLine(name + "'s earnings are $" + earnings);
    } 
}
