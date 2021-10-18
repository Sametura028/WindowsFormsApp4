using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          

        }


        
        private void tmrsure_Tick(object sender, EventArgs e)
        {
           
            Random rastgele = new Random();
            Random rastgele2 = new Random();
            Random rastgele3 = new Random();


          
            pictureBox1.Left += rastgele.Next(0, 15);
           
            pictureBox2.Left +=  rastgele2.Next(0, 15);
        
                pictureBox3.Left += rastgele.Next(0, 15);
            if (pictureBox1.Left>=label1.Left)
            {
                tmrsure.Enabled = false;
                label1.Text="araba 1 kazandı";
            }
            else if (pictureBox2.Left >= label1.Left)
            {
                tmrsure.Enabled = false;
                label1.Text = "araba 2 kazandı";
            }
            else if (pictureBox3.Left >= label1.Left)
            {
                tmrsure.Enabled = false;
                label1.Text = "araba 3 kazandı";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrsure.Enabled = true;
        }
    }
}
