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
                    int x = 12 + 100 * rad;
                    int y = 12 + 100 * kolumn;
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
                int x = 200;
                int y = 100;

                //Rita text till skärm
                g.DrawString(text, Font, brushTillText, x, y);
            }

        }


        //Musklick

        protected override void OnMouseClick(MouseEventArgs e)
        {
            bool traff = false;
            int musX = e.X;
            int musY = e.Y;

            //Gå igenom alla rektanglar till träff hittas
            for (int i = 0; i < rektanglar.Count && !traff; i++)
            {

                //Kolla efter träff på varje
                Rektangel temporarRektangel3 = rektanglar.ElementAt(i);
                traff = temporarRektangel3.Traffad(musX, musY);

                //Radera träffad rektangel
                if (traff)
                {
                    rektanglar.RemoveAt(i);
                }
            }

            //Spelet slut vid noll rektanglar kvar

            if (rektanglar.Count == 0)
            {
                speletSlut = true;
            }

            //Invalidate. Rita om fönster
            Invalidate();

        }


    }
}
