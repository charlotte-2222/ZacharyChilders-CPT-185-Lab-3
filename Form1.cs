//Zachary Childers
//CPT-185-A01S
//Lab-3
//9-5-2020`

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZacharyChilders_CPT_185_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                double ticCostA = 15, ticCostB = 12, ticCostC = 9;
                double ticA, ticB, ticC, aTot, bTot, cTot, fulTot;
                ticA = double.Parse(ticketA.Text);
                ticB = double.Parse(ticketB.Text);
                ticC = double.Parse(ticketC.Text);
                aTot = ticA * ticCostA; // Trying to keep everything condensed
                bTot = ticB * ticCostB; // And use as few lines as possible
                cTot = ticC * ticCostC; // *Sidenote, almost forgot about currency conversion.*
                ticRevA.Text = aTot.ToString("C");
                ticRevB.Text = bTot.ToString("C");
                ticRevC.Text = cTot.ToString("C");
                fulTot = aTot + bTot + cTot;totals.Text = fulTot.ToString("C");
            }
            catch
            {
                MessageBox.Show("There was a problem issuing your command, or you have entered an invalid data-type. " + 
                    "Please be sure to only enter numeric values.");
                   
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            ticketA.Text = " ";                  
            ticketB.Text = " ";
            ticketC.Text = " ";
            ticRevA.Text = " ";             //Standard clr
            ticRevB.Text = " ";
            ticRevC.Text = " ";
            totals.Text = " ";
            ticketA.Focus();


        }

        private void ext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a great day, and enjoy the game!");
            Close();
            
        }
        protected override void OnPaint(PaintEventArgs e)
            //doing a little something extra here -
            // this overrides some graphic settings and lets me add a green "glow" border
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.LimeGreen, ButtonBorderStyle.Solid);
        }
    }
}
