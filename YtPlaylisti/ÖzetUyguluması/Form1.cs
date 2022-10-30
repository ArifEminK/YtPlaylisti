using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖzetUyguluması
{
    public class GenerateButtons
    {
        private Form1 _form1;

        public GenerateButtons(Form1 form1)
        {
            _form1 = form1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(0); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left = left + 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    _form1.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
                

            }

        }
    }

    public partial class Form1 : Form
    {
        private readonly GenerateButtons GenerateButtons;

        public Form1()
        {
            InitializeComponent();
            GenerateButtons = new GenerateButtons(this);
        }

        public GenerateButtons GenerateButtons1
        {
            get { return GenerateButtons; }
        }
    }
}
