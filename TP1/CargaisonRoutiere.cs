using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class CargaisonRoutiere : Cargaison
    {
        public CargaisonRoutiere(double dist) : base(dist) { }

        public override double Cout()
        {
            if( this.GetVolumeTotal() < 380000)
            {
                return 4 * this.GetPoidsTotal();
            }
            else
            {
                return 6 * this.GetPoidsTotal();
            }
            
        }


        public override string ToString()
        {
            return "Cargaison Routiére" + Distanace;
        }
    }
}
