using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    abstract class Cargaison
    {
        protected double distanace;
        protected List<Marchandise> marchandises = new List<Marchandise>();
        public double Distanace
        {
            get { return distanace; }
            set { distanace = value; }
        }

        public Cargaison(double distanace)
        {
            this.distanace = distanace;
        }

        public void Add(Marchandise a)
        {
            marchandises.Add(a);
        }
        public void afficher()
        {
            Console.WriteLine("A propos des Marhandise dans le Cargaison :");
            foreach(Marchandise m in marchandises)
            {
                Console.WriteLine(m);
                Console.WriteLine("-----------------------------------");
            }
        }


        public List<Marchandise> GetMarchandises()
        {
            return marchandises;
        }
        public Marchandise GetMarchandises(int n)
        {
            foreach (Marchandise m in marchandises)
            {
                if(m.Numero == n)   return m;
            }
            throw new Exception("Marchandise Introuvable !");
        }
        public double GetPoidsTotal()
        {
            double poidTotal = 0;
            foreach (Marchandise m in marchandises)
            {
                poidTotal += m.Numero;
            }
            return poidTotal;
        }
        public double GetVolumeTotal()
        {
            double volumeTotal = 0;
            foreach (Marchandise m in marchandises)
            {
                volumeTotal += m.Volume;
            }
            return volumeTotal;
        }
        public abstract double Cout();


    }
}
