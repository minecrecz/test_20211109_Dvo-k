using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2021_Dvořák
{

    public partial class Form1 : Form
    {
        private Banka banka;
        private readonly int zustatek;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banka = new Banka("Jiří Slaný", 30000, "98652/56");
            labelJmeno.Text = banka.jmeno; 
            lbl_aktualni.Text = $"{banka.zustatek}";
            labelCisloUctu.Text = $"{banka.cisloUctu}";
          


        }

        private void btn_vklad_Click(object sender, EventArgs e)
        {
            
            banka.Vklad(zustatek);
            MessageBox.Show($"Vloženo{zustatek}kč" );
        }

        private void btn_výběr_Click(object sender, EventArgs e)
        {
            
            banka.Vyber(zustatek);
            MessageBox.Show($"Vybral si{zustatek}kč");
          
        }

        private void č_vyber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_platba_Click(object sender, EventArgs e)
        {
            banka.Platba(zustatek);
            MessageBox.Show($"Zaplatil si {zustatek}kč");
        }
    }
}

           
