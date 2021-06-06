using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Maintest(string[] args)
        {
            Marchandise m1 = new Marchandise(711, 13, 5);
            Marchandise m2 = new Marchandise(712, 15, 7);
            Marchandise m3 = new Marchandise(713, 17, 9);

            CargaisonRoutiere cargaisonR = new CargaisonRoutiere(7500);
            CargaisonAerienne cargaisonA = new CargaisonAerienne(5700);
            cargaisonA.Add(m1);
            cargaisonA.Add(m2);
            cargaisonA.Add(m3);
            cargaisonR.Add(m1);
            cargaisonR.Add(m2);
            cargaisonR.Add(m3);

            cargaisonA.afficher();

            Console.WriteLine(cargaisonR.GetPoidsTotal());

            Console.WriteLine("Le cout total est : \n");
            Console.WriteLine("Cargaison Aerienne : " + cargaisonA.Cout());
            Console.WriteLine("Cargaison Routiere : " + cargaisonR.Cout());

            Console.ReadKey(true);


        }
    }
}
