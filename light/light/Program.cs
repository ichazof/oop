using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace light
{
    class Mlight
    {
        private int ratedPower=0;
        private int ratedVoltage=0;
        private bool isTurn=false;
        public int readRatedPower() { return ratedPower; }
        public void createRatedPower(int temp) { ratedPower = temp; }
        public int readRatedVoltage() { return ratedVoltage; }
        public void createRatedVoltage(int temp) { ratedVoltage = temp; }
        public void TurnOn() { isTurn = true; }
        public void TurnOff() { isTurn = false; }


    };

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            

        }
    }
}
