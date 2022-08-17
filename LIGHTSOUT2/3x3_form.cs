using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGHTSOUT2
{
    public partial class _3x3_okno : Form
    {
        public _3x3_okno()
        {
            InitializeComponent();
        }

        private bool is_btn1_Clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (is_btn1_Clicked)  
                btn_1.BackColor = Color.DarkBlue;
            else
                btn_1.BackColor = Color.Yellow;
            is_btn1_Clicked = !is_btn1_Clicked;

        }
        private bool is_btn2_Clicked = false;
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (is_btn2_Clicked)
                btn_2.BackColor = Color.DarkBlue;
            else
                btn_2.BackColor = Color.Yellow;
            is_btn2_Clicked = !is_btn2_Clicked;
        }
        private bool is_btn3_Clicked = false;
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (is_btn3_Clicked)
                btn_3.BackColor = Color.DarkBlue;
            else
                btn_3.BackColor = Color.Yellow;
            is_btn3_Clicked = !is_btn3_Clicked;
        }
        private bool is_btn4_Clicked = false;
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (is_btn4_Clicked)
                btn_4.BackColor = Color.DarkBlue;
            else
                btn_4.BackColor = Color.Yellow;
            is_btn4_Clicked = !is_btn4_Clicked;
        }
        private bool is_btn5_Clicked = false;
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (is_btn5_Clicked)
                btn_5.BackColor = Color.DarkBlue;
            else
                btn_5.BackColor = Color.Yellow;
            is_btn5_Clicked = !is_btn5_Clicked;
        }
        private bool is_btn6_Clicked = false;
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (is_btn6_Clicked)
                btn_6.BackColor = Color.DarkBlue;
            else
                btn_6.BackColor = Color.Yellow;
            is_btn6_Clicked = !is_btn6_Clicked;
        }
        private bool is_btn7_Clicked = false;
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (is_btn7_Clicked)
                btn_7.BackColor = Color.DarkBlue;
            else
                btn_7.BackColor = Color.Yellow;
            is_btn7_Clicked = !is_btn7_Clicked;
        }
        private bool is_btn8_Clicked = false;
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (is_btn8_Clicked)
                btn_8.BackColor = Color.DarkBlue;
            else
                btn_8.BackColor = Color.Yellow;
            is_btn8_Clicked = !is_btn8_Clicked;
        }
        private bool is_btn9_Clicked = false;
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (is_btn9_Clicked)
                btn_9.BackColor = Color.DarkBlue;
            else
                btn_9.BackColor = Color.Yellow;
            is_btn9_Clicked = !is_btn9_Clicked;
        }

        Button[,] pole_tlacitek = new Button[3,3];
        private void UdelejPole()
        {
            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
            }
        }

        private void btn_hrat_Click(object sender, EventArgs e)
        {

        }
    }
}
