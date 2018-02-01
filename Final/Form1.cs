using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Q2Btn_Click(object sender, EventArgs e)
        {
            // Question2: capture the 2 integer inputs
            Int32 input1 = Convert.ToInt32(textBox1.Text);
            Int32 input2 = Convert.ToInt32(textBox2.Text);

            //Question3:  
            String[] msg = { " Happy ", " New ", " Year ", "C# is cool"};

            Console.WriteLine(msg);

            //Question4: 
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] players = new string[3, 2];
            players[0, 0] = "Auston Matthews";
            players[0, 1] = "34";
            players[1, 0] = "Morgan Rielly";
            players[1, 1] = "44";
            players[2, 0] = "Mitch Marner";
            players[2, 1] = "16";

            Int32 total = 0;

            for (Int32 i = 0; i < players.GetLength(0); i++)
            
            Console.WriteLine(players.GetLength(0));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 x = 36;
            Int32 y = 9;
            Int32 result = Convert.ToInt32(x) / Convert.ToInt32(y);

            lblQ7.Text = Convert.ToString(result);
        }
    }
}
