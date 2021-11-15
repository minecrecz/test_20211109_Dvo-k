using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2021_Dvořák
{
    class Banka
    {
        public string jmeno { get; }
        public string cisloUctu { get; }
        public int zustatek { get; set; }
        public int max = 200000;
        public int tyden_Limit = 3000;
        public int platba_Limit = 10000;
        public float Stav = 0;

        public Banka(string jmeno, int zustatek, string cisloUctu)
        {
            this.jmeno = jmeno;
            this.zustatek = zustatek;
            this.cisloUctu = cisloUctu;
        }
        public void Vklad(int vklad)
        {

           if(zustatek > max)
            {
                MessageBox.Show("Tato částka přesahuje možnost maximálního vkladu");
            }
           else if(zustatek<=max && zustatek>0)
            {
                Stav += zustatek;
                MessageBox.Show("vklad byl úspěšný");
                

            }

        }
        public void Vyber(int vyber)
        {

            if (zustatek <=Stav && zustatek !=0)
            {

                MessageBox.Show($"vybral jsi {zustatek} kč a zbylo ti {Stav} ");
            }
            else if (vyber > Stav)
               {
                MessageBox.Show("nebylo možno vybrat");
                
            }
        }
        public void Platba(int platba)
        {

            if (zustatek>platba_Limit)
            {
                MessageBox.Show("tvoje platba převyšuje maximální limit ");
            }
            else if(platba < zustatek)
               {
                MessageBox.Show("není dostatek peněz na účtu");
            }
            else if (zustatek<= platba_Limit)
            {
                Stav -= zustatek;
                MessageBox.Show($"Platba byla úspěšná");
            }
        }
    }
}
