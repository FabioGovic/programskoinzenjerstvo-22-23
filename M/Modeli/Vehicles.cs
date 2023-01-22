using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Modeli
{
    public class Vehicles
    {
        public enum Type { Truck, Car, Bus, Van }
        private Type vrsta;
        private int velicinaBat;
        private int velicinaRez;


        private int fare;
        public Vehicles(Type vrsta, int velicinaBat, int velicinaRez)
        {
            this.vrsta = vrsta;
            this.velicinaBat = velicinaBat;
            this.velicinaRez = velicinaRez;


            switch (vrsta)
            {
                case Type.Truck:
                    fare = Konstanto.;
                    break;
                case Type.Car:
                    fare = Konstanto.;
                    break;
                case Type.Bus:
                    fare = Konstanto.;
                    break;
                case Type.Van:
                    fare = Konstanto.;
                    break;
                default:
                    fare = Konstanto.;
                    break;
            }
        }
        public int GetFare() => fare;
        public double GetvelicinaRez() => velicinaRez;
        public double GetvelicinaBat() => velicinaBat;
        public Type GetVrsta() => vrsta;

        public void SetvelicinaRez() => velicinaRez = Konstanto.SIZE_HIGH;
        public void SetvelicinaBat() => velicinaBat = Konstanto.SIZE_HIGH;

    }
}
