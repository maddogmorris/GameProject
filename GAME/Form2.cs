using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAME
{
    public partial class Form2 : Form
    {
        int X = Form1.x;
        int Y = Form1.y;
        public static int picbox = 1;
        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            X += 1;
            if (X >= 5) { MessageBox.Show("you have gone to far"); X += -1; }
            else
            {
                MessageBox.Show("you moved up and you moved up and you are in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                picbox += 1;


            }

        }
        enum terrian { grassland = 1, sanddunes, ocean, forset }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Y += 1;
            if (Y >= 5) { MessageBox.Show("you have gone to far"); Y += -1; }
            else
            {
                MessageBox.Show("you moved right and you moved in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                picbox += 5;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            X += -1;
            if (X <= -1) { MessageBox.Show("you have gone to far"); X += 1; }
            else
            {
                MessageBox.Show("you moved down and you moved in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                picbox += -1;


            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Y += -1;
            if (Y <= -1) { MessageBox.Show("you have gone to far"); Y += 1; }
            else
            {
                MessageBox.Show("you moved left and you moved in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                picbox += -5;


            }
        }

    }
}
