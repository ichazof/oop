using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace light
{
    

    public partial class Form1 : Form
    {
        Mlight light1 = new Mlight();
        
        public Form1()
        {
            InitializeComponent();
            light1.createRatedPower(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPower.Text = light1.readRatedPower().ToString();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            light1.createRatedPower(Convert.ToInt32(textBoxPower.Text));
            light1.createRatedVoltage(Convert.ToInt32(textBoxVoltage.Text));
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            labelPower.Text = light1.readRatedPower().ToString();
            labelVoltage.Text = light1.readRatedVoltage().ToString();
        }
    }
}
