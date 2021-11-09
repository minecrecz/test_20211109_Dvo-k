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
        public float zustatek { get; set; }
        public int max = 200000;
        public int tyden_Limit = 3000;
        public int platba_Limit = 10000;


        public Banka(string jmeno, float zustatek, string cisloUctu)
        {
            this.jmeno = jmeno;
            this.zustatek = zustatek;
            this.cisloUctu = cisloUctu;
        }
        public void Vklad(int vklad)
        {

            if (vklad + zustatek <= max)
            {
                zustatek += vklad;
                
            }
            else if(vklad + zustatek >= max)
            {

                MessageBox.Show("Váš maximální limit je: " + max);
            }

        }
        public void Vyber(float vyber)
        {

            if (vyber - zustatek <= 0 && vyber <= tyden_Limit)
            {
                zustatek -= vyber;
                MessageBox.Show("Bylo vybráno: " + vyber.ToString());
            }
            else if (vyber < zustatek)
               {
                MessageBox.Show("nebylo možno vybrat");
            }
        }
        public void Platba(float platba)
        {

            if (platba - zustatek <= 0 && platba <= tyden_Limit)
            {
                zustatek -= platba;
                return platba;
            }
            else if(platba < zustatek)
               {
                MessageBox.Show("nebylo možno vybrat");
            }
        }
    }
}
