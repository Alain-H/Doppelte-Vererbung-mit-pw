using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string pw = "1234";
        public Anmeldung Fvier = null;
        
        int count = 0;  

        public Form2(Form f4)
        {
            Fvier = f4 as Anmeldung;
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(textBox1.Text == pw)
            {
                Fvier.f1 = label2.Text + "\nSie haben sich korrekt eingeloggt!" ;
                this.Hide();
                count = 0;
            }
             else
            {
                count++;
                if (count == 1)
                    label4.Text = "Sie haben noch 2 Versuche ";
                else if (count == 2)
                    label4.Text = "Sie haben noch 1 versuch!";
                else if (count == 3)
                    label4.Text = "Sie haben zu viele versuche gebraucht versuchen sie es in 30 min erneut!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
