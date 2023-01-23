using M.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Interface
{
    public interface IRecharge
    {
        void Check(Vehicles vehicle, Trains train);
    }
}
