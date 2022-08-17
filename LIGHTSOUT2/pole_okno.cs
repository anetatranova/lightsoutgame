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
    public partial class pole_okno : Form
    {
        public pole_okno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3x3_okno _3X3_okno = new _3x3_okno();
            _3X3_okno.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _5x5_okno _5X5_Okno = new _5x5_okno();
            _5X5_Okno.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _7x7_okno _7X7_Okno = new _7x7_okno();  
            _7X7_Okno.Show();
        }
    }
}
