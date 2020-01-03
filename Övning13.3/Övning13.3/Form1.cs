using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning13._3
{
    public partial class Form1 : Form
    {

        Queue<string> namnLista = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNyKund_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            namnLista.Enqueue(namn);
            tbxNamn.Text = "";
        }

        private void BtnExpediera_Click(object sender, EventArgs e)
        {
            try
            {
                string namn = namnLista.Dequeue();

                lblUt.Text = namn + " har expedierats";
            }
            catch
            {
                lblUt.Text = "Inga kunder kvar i kön";
            }

        }
    }
}
