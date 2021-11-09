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
        Banka banka;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banka = new Banka("Jiří Slaný", 30000, "98652/56");
            labelJmeno.Text = banka.jmeno;
            labelCisloUctu.Text = $"{banka.cisloUctu}";
            lbl_aktualni.Text = $"{banka.zustatek}";


        }

        private void btn_vklad_Click(object sender, EventArgs e)
        {
            var zustatek = banka.Vklad(Convert.ToInt32(č_vklad));
            MessageBox.Show($"Vloženo{zustatek}kč");
        }

        private void btn_výběr_Click(object sender, EventArgs e)
        {
            var zustatek = banka.Vyber(Convert.ToInt32(č_vyber));
            MessageBox.Show($"Vybral{zustatek}kč");
        }

        private void č_vyber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_platba_Click(object sender, EventArgs e)
        {
            var zustatek = banka.Platba(Convert.ToInt32(č_vklad));
            MessageBox.Show($"Zaplatil si {zustatek}kč");
        }
    }
}

           
