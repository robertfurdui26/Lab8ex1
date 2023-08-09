using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8ex1
{
    internal class Tren
    {
        public string name { get; set; }
        private List<Vagon> vagoane = new List<Vagon>();

        public Tren(string Name)
        {
            this.name = Name;
        }

        public void AdaugaVagon(Vagon v)
        {
            vagoane.Add(v);
            Console.WriteLine($"Vagonul a fost adaugat la trenul {name}");
        }

        public void PleacareGara()
        {
            foreach(var vagon in vagoane)
            {
                if(vagon is VagonPersoane vagonPersoane)
                {
                    vagonPersoane.usiInchisa = true;
                }
            }

            PornesteLocomotiva();

            Console.WriteLine($"Trenul {name} a plecat din gara.");
        }

        public void OprireInGara()
        {
            foreach( var vagon in vagoane)
            {
                if(vagon is VagonPersoane vagonPersoane)
                {
                    vagonPersoane.usiDeschise = true;
                }
            }

            foreach( var vagon in vagoane)
            {
                if(vagon is VagonPersoane vagonPersoane && vagonPersoane.clasa == 1)
                {
                    vagonPersoane.aerConditiont = false;

                }
            }

            OpresteLocomotiva();
            Console.WriteLine($"Trenul {name} a oprit in gara.");
        }

        public void PornesteLocomotiva()
        {
            Console.WriteLine("Locomotiva a pornit");
        }

        public void OpresteLocomotiva()
        {
            Console.WriteLine("Locomotiva a oprit");
        }

    }








    class Vagon
    {
        public int masa { get; set; }
        public int anulFabricatiei { get; set; }



        public Vagon(int masa, int anulFabricatiei)
        {
            this.masa = masa;
            this.anulFabricatiei = anulFabricatiei;
        }

    }


    class VagonMarfa : Vagon
    {
        public int capacitate { get; set; }

        public string tipMarfa { get; set; }

        public VagonMarfa(int masa, int anulFabricatiei, string tipMarfa) : base(masa, anulFabricatiei)
        {
            this.capacitate = masa * 12;
            this.tipMarfa = tipMarfa;
        }
    }

    class VagonPersoane : Vagon
    {
        public int nrDeLocuri { get; set; }
        public int clasa { get; set; }

        public bool aerConditiont { get; set; }

        public bool usiInchisa { get; set; }

        public bool usiDeschise { get; set; }


        public VagonPersoane(int masa, int anulFabricatiei, int nrDeLocuri, int clasa) : base(masa, anulFabricatiei)
        {
            this.nrDeLocuri = nrDeLocuri;
            this.clasa = clasa;
            this.usiInchisa = true;
            this.usiDeschise = true;
            this.aerConditiont = false;
        }

        public void InchideUsile()
        {
           this.usiInchisa = true;
            Console.WriteLine("Ușile vagonului au fost închise.");
        }

        public void DeschideUsile()
        {
            this .usiDeschise = true;
            Console.WriteLine("Ușile vagonului au fost deschise.");
        }

        public void PornesteAerConditionat()
        {
            this.aerConditiont = true;
            Console.WriteLine("Aerul condiționat a fost pornit.");
        }

        public void OpresteAerConditionat()
        {
            this.aerConditiont = false;
            Console.WriteLine("Aerul condiționat a fost oprit.");
        }
    }

   
}
