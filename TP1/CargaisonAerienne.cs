using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class CargaisonAerienne : Cargaison
    {  
        public CargaisonAerienne(double dist): base(dist) { }

        public override double Cout()
        {
            if (this.GetVolumeTotal() < 8000)
            {
                return 10 * this.GetPoidsTotal();
            }
            else
            {
                return 12 * this.GetPoidsTotal();
            }

        }

        public override string ToString()
        {
            return "Cargaison Aerienne" + Distanace;
        }

    }
}
