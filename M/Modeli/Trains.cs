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
        private int capacity = Konstantno.ZERO;
        private Velicina v;


        public Trains(Velicina v)
        {
            this.v = v;
            if (v == Velicina.Small)
                capacity = Konstantno.SMALL_TRAIN_SIZE;
            else
                capacity = Konstantno.LARGE_TRAIN_SIZE;
        }

        public int GetCapacity() => capacity;
        public void SetCapacity() => capacity--;
        public Velicina GetSize() => v;
    }
}
