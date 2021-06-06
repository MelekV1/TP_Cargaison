using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Marchandise
    {
        private int numero;
        private double poids;
        private double volume;

        public Marchandise(int numero, double poids, double volume)
        {
            this.numero = numero;
            this.poids = poids;
            this.volume = volume;
        }

        public  int Numero {
            get { return numero ; }
            set { numero = value;  }
        }
        public double Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public override string ToString()
        {
            return $"Marchandise : {numero} , \nPoid : {poids},\nVolume : {volume}";
        }
    }
}
