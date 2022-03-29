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
    public partial class Anmeldung : Form
    {
        Form2 fm2;
        
        string name = "Hoch";
        string name2 = "Stertsos";
        string vorname = "Alain";
        string vorname2 = "Achillefs";
        int count = 0;
        public string f1
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public Anmeldung()

        {
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
            if(textBox1.Text == name && textBox2.Text == vorname || textBox1.Text == name2 && textBox2.Text == vorname2)
            {
                fm2 = new Form2(this);
                fm2.label2.Text = "Hallo " + textBox1.Text + " " + textBox2.Text;
                fm2.Show();

                

                count = 0;
            }
            else
            {
                label4.Text = "Falsche Logindaten!";
                
                   
            }
        }
    }
}
