using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Modeli
{
    public class Trains
    {
        public enum Velicina { Small, Large }
        private int capacity = Konst.NULA;
        private Velicina v;


        public Trains(Velicina v)
        {
            this.v = v;
            if (v == Velicina.Small)
                capacity = Konst.MALI_VLAK_VEL;
            else
                capacity = Konst.VELIKI_VLAK_VEL;
        }

        public int GetCapacity() => capacity;
        public void SetCapacity() => capacity--;
        public Velicina GetSize() => v;
    }
}
