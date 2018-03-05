using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Threading.Tasks;

namespace GAME
{
    
    public partial class Form1 : Form
    {
        bool movement = false;
        int X = Form1.x;
        int Y = Form1.y;
        public static int oldpic = 0;
        public static int picbox = 1;
        public static int x = 0;
        public static int y = 0;
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        int OLDpic = oldpic;
        int PICbox = picbox;
       public Random rnd = new Random();
       
        public Form1()
        {
            InitializeComponent();
          
        }
        public class map
        {
            public static int[,] bob = new int[,]{
          {1,1,2,3,3},
          {1,1,2,3,3},
          {1,1,1,2,2},
          {2,2,1,4,4},
          {2,4,4,4,4}};
             
        }
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
               
                int monsters = rnd.Next(0, 2);
               
                //capture down arrow key
                if (keyData == Keys.Down)
                {
                    X += 1;
                    if (X >= 5) { MessageBox.Show("you have gone to far"); X += -1; }
                    else
                    {
                        MessageBox.Show("you moved down and you are in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                        oldpic = picbox;
                        picbox += 1;
          
                    }
                    return true;
                }
                //capture up arrow key
                if (keyData == Keys.Up)
                {
                    X += -1;
                    if (X <= -1) { MessageBox.Show("you have gone to far"); X += 1; }
                    else
                    {
                        MessageBox.Show("you moved up and you moved in " + Convert.ToString((terrian)Form1.map.bob[X, Y]),"title");
                        oldpic = picbox;
                        picbox += -1;
                 

                    }
                    return true;
                }
                //capture left arrow key
                if (keyData == Keys.Left)
                {
                    Y += -1;
                    if (Y <= -1) { MessageBox.Show("you have gone to far"); Y += 1; }
                    else
                    {
                        MessageBox.Show("you moved left and you moved in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                        oldpic = picbox;
                        picbox += -5;
                        

                    }
                    return true;
                }
                //capture right arrow key
                if (keyData == Keys.Right)
                {
                    Y += 1;
                    if (Y >= 5) { MessageBox.Show("you have gone to far"); Y += -1; }
                    else
                    {
                        MessageBox.Show("you moved right and you moved in " + Convert.ToString((terrian)Form1.map.bob[X, Y]));
                        oldpic = picbox;
                        picbox += 5;
                      
                    }
                    return true;
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }//movement keys



        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            int PICbox = Form1.picbox;
            int OLDpic = Form1.oldpic;
            if (PICbox == 1) { pictureBox1.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 2) { pictureBox2.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 3) { pictureBox3.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 4) { pictureBox4.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 5) { pictureBox5.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 6) { pictureBox6.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 7) { pictureBox7.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 8) { pictureBox8.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 9) { pictureBox9.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 10) { pictureBox10.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 11) { pictureBox11.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 12) { pictureBox12.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 13) { pictureBox13.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 14) { pictureBox14.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 15) { pictureBox15.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 16) { pictureBox16.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 17) { pictureBox17.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 18) { pictureBox18.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 19) { pictureBox19.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 20) { pictureBox20.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 21) { pictureBox21.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 22) { pictureBox22.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 23) { pictureBox23.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 24) { pictureBox24.Image = GAME.Properties.Resources.download__1_; movement = true; }
            else if (PICbox == 25) { pictureBox25.Image = GAME.Properties.Resources.download__1_; movement = true; }

            if (movement == true)
            {
                if (OLDpic == 1) { pictureBox1.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 2) { pictureBox2.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 3) { pictureBox3.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 4) { pictureBox4.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 5) { pictureBox5.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 6) { pictureBox6.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 7) { pictureBox7.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 8) { pictureBox8.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 9) { pictureBox9.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 10) { pictureBox10.Image = GAME.Properties.Resources.forest; movement = false; }
                else if (OLDpic == 11) { pictureBox11.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 12) { pictureBox12.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 13) { pictureBox13.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 14) { pictureBox14.Image = GAME.Properties.Resources.grass_small; movement = false; }
                else if (OLDpic == 15) { pictureBox15.Image = GAME.Properties.Resources.forest; movement = false; }
                else if (OLDpic == 16) { pictureBox16.Image = GAME.Properties.Resources.ocean_water_1479055199; movement = false; }
                else if (OLDpic == 17) { pictureBox17.Image = GAME.Properties.Resources.ocean_water_1479055199; movement = false; }
                else if (OLDpic == 18) { pictureBox18.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 19) { pictureBox19.Image = GAME.Properties.Resources.forest; movement = false; }
                else if (OLDpic == 20) { pictureBox20.Image = GAME.Properties.Resources.forest; movement = false; }
                else if (OLDpic == 21) { pictureBox21.Image = GAME.Properties.Resources.ocean_water_1479055199; movement = false; }
                else if (OLDpic == 22) { pictureBox22.Image = GAME.Properties.Resources.ocean_water_1479055199; movement = false; }
                else if (OLDpic == 23) { pictureBox23.Image = GAME.Properties.Resources.download; movement = false; }
                else if (OLDpic == 24) { pictureBox24.Image = GAME.Properties.Resources.forest; movement = false; }
                else if (OLDpic == 25) { pictureBox25.Image = GAME.Properties.Resources.forest; movement = false; }
            }
        }//movement code
        
    

        public void RandNum()
        {
            int monsterfinder = rnd.Next(0, 9);
            if (monsterfinder <= 4)
            {
                
            }
        
        }
        
        




        enum terrian { grassland = 1, sanddunes, ocean, forset }
        }//form

        
    }//namespace

    
           

