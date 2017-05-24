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
        Mlight light2 = new Mlight();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox1Power.Text = light1.readRatedPower().ToString();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            light1.createRatedPower(Convert.ToInt32(textBox1Power.Text));
            light1.createRatedVoltage(Convert.ToInt32(textBox1Voltage.Text));
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            label1Power.Text = light1.readRatedPower().ToString();
            label1Voltage.Text = light1.readRatedVoltage().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2Get_Click(object sender, EventArgs e)
        {
            light2.createRatedPower(Convert.ToInt32(textBox2Power.Text));
            light2.createRatedVoltage(Convert.ToInt32(textBox2Voltage.Text));
        }

        private void button2Read_Click(object sender, EventArgs e)
        {
            label2Power.Text = light2.readRatedPower().ToString();
            label2Voltage.Text = light2.readRatedVoltage().ToString();
        }
    }
}
