
using System;

namespace Lab8ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tren tren = new Tren("Rapidul");

            VagonMarfa vagonMarfa = new VagonMarfa(1000, 2010, "Produse alimentare");
            tren.AdaugaVagon(vagonMarfa);

            VagonPersoane vagonPersoane = new VagonPersoane(800, 2015, 50, 2);
            tren.AdaugaVagon(vagonPersoane);

            tren.PleacareGara();
            tren.OprireInGara();

            vagonPersoane.InchideUsile();
            vagonPersoane.PornesteAerConditionat();
            

            vagonPersoane.DeschideUsile();
            vagonPersoane.OpresteAerConditionat();
            

        }
    }
}