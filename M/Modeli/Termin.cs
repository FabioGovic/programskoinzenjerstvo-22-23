using M.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Modeli
{
    public class Termin: IPark
    {
        private Trains maliVlak;
        private Trains velikiVlak;
        private int ticketEarnings = Konst.NULA;

        public Termin(Trains.Velicina velicinaVlaka)
        {
            if (velicinaVlaka == Trains.Velicina.Small)
                maliVlak= new Trains(velicinaVlaka);
            else
                velikiVlak = new Trains(velicinaVlaka);
        }

        public void Park(Vehicles vehicle, Employee employee)
        {
            if (vehicle.GetVrsta() == Vehicles.Type.Car || vehicle.GetVrsta() == Vehicles.Type.Van)
                employee.Check(vehicle, maliVlak);

            else
                employee.Check(vehicle, velikiVlak);

            ticketEarnings += vehicle.GetFare();
            Console.WriteLine();
        }
        public void GetTicketEarnings() => Console.WriteLine("Total earnings from tickets at this terminal is $" + ticketEarnings);

    }
}
