using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning13._1
{
    public partial class Form1 : Form
    {

        List<Rektangel> rektanglar = new List<Rektangel>();
        bool speletSlut = false;


        public Form1()
        {
            InitializeComponent();

            //Generera rektanglar (4x4 grid)

            for(int rad = 0; rad < 4; rad++)
            {
                for(int kolumn = 0; kolumn < 4; kolumn++)
                {
                    //Skapa värden
                    int x = 10 + 100 * rad;
                    int y = 10 + 100 * kolumn;
                    int hojd = 50;
                    int bredd = 75;

                    //Skapa temporärt object, rektangel av värden
                    Rektangel temporarRektangel = new Rektangel(x, y, hojd, bredd);
                    //Lägga till temporär rektangel i lista
                    rektanglar.Add(temporarRektangel);
                }
            }


        }



        //Rita till skärm

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Rita rektanglar
            for(int i = 0; i < rektanglar.Count; i++)
            {
                //Skapa temporärt objekt, rektangel för att extrahera ur listan
                Rektangel temporarRektangel2 = rektanglar.ElementAt(i);
                temporarRektangel2.Rita(g);
            }

            //Om spelet är slut
            if (speletSlut)
            {
                //Variabler
                string text = "Grattis!";
                Font = new Font("Arial", 30);
                SolidBrush brushTillText = new SolidBrush(Color.Blue);

                //Plats
                int x = 50;
                int y = 50;

                //Rita text till skärm
                g.DrawString(text, Font, brushTillText, x, y);
            }

        }


        //Musklick

        protected override void OnMouseClick(MouseEventArgs e)
        {
            
        }


    }
}
