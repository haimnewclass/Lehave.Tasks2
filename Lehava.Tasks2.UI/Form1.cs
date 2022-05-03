using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehava.Tasks2.UI
{
    public partial class Form1 : Form
    {
        Lehava.Tasks2.Core.MainMng  mainMng = new Core.MainMng();

        public Form1()
        {
            InitializeComponent();
        }

        public void PrintNum()
        {
            button1.Text = "123";
        }

        public void PrintNum2()
        {
            button1.Text = "222";
        }



        private void button1_Click(object sender, EventArgs e)
        {

            mainMng.Run();
            mainMng.MainLoop();

            /*
            int k = mainMng.GetNum(23);
            int k1 = 5 * 5;

            Action func = PrintNum;
            func = PrintNum2;
            func = () =>
            {               
                button1.Text = k.ToString();
            };

            func();

            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = mainMng.iteration.ToString();
        }
    }
}
