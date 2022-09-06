using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGHTSOUT2
{
    public partial class _3x3_okno : Form
    {
        public Button[,] buttons = new Button[3,3];
        public int velikost = 3;
        public bool[,] lights = new bool[3,3];

        public bool[,] solution = new bool[3,3];

        int timeMin, timeSec;
        int a, b;

        public int moves;

        public _3x3_okno()
        {
            buttons = new Button[3, 3] { {btn_11,btn_12, btn_13 },
                { btn_21, btn_22, btn_23},
                { btn_31, btn_32, btn_33} };

            InitializeComponent();
            InicializacePole();
        }
        private void _3x3_okno_Load(object sender, EventArgs e)
        {

        }

        public void InicializacePole()
        {
            buttons = new Button[3, 3] { {btn_11,btn_12, btn_13 },
                { btn_21, btn_22, btn_23},
                { btn_31, btn_32, btn_33} };

            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    buttons[i, j].Name = "X: " + i + " " + "Y: " + j;
                    buttons[i, j].BackColor = Color.DarkBlue;
                    buttons[i, j].Enabled = false;
                    buttons[i, j].Text = "";
                    lights[i, j] = false;
                    solution[i, j] = false;
                    moves = 0;
                }
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int x = int.Parse(button.Name.Split()[1]);
            int y = int.Parse(button.Name.Split()[3]);
            toggleLight(buttons[x, y], x, y);

            moves++;
            moves_count();

            solution[x, y] = !solution[x, y];

            if (solution[x,y] == false)
                buttons[x, y].Text = "";

            CheckEnd();
        }

        private void start_Click(object sender, EventArgs e)
        {
            InicializacePole();
            foreach (Button btn in buttons)
                btn.Enabled = true;
            ResetTime();
            moves_count();
            timer1.Start();
            Start();
        }

        private void ResetTime()
        {
            timeMin = 0;
            timeSec = 0;
            a = timeSec;
            b = timeMin;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = timeSec++;
            timeMin = 0;
            if (timeSec == 60)
            {
                timeSec = 0;
                timeMin++;
                b = timeMin;
            }
            txt_time.Text = String.Format("{0}:{1}", b.ToString().PadLeft(2, '0'), a.ToString().PadLeft(2, '0'));
        }

        public void switchLight (object sender, int x, int y)
        {
            lights[x, y] = !lights[x, y];

            if (lights[x, y])
                buttons[x,y].BackColor = Color.Yellow;
            else
                buttons[x,y].BackColor = Color.DarkBlue;
        }

        public void toggleLight(object sender, int x, int y)
        {
            switchLight(buttons[x, y], x, y);
            
            if (x < velikost - 1)
                switchLight(buttons[x+1,y],x+1, y);
            if (x > 0)
                switchLight(buttons[x - 1, y],x - 1, y);
            if (y < velikost - 1)
                switchLight(buttons[x, y+1], x, y+1);
            if (y > 0)
                switchLight(buttons[x, y-1], x, y-1);

        }

        public void Start()
        {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(velikost, velikost*velikost); i++)
            {
                int x = rnd.Next(0, velikost - 1);
                int y = rnd.Next(0, velikost - 1);
                toggleLight(buttons[x, y], x, y);

                solution[x,y] = !solution[x,y];
            }

            if (CheckWin() == true)
            {
                Start();
            }

        }

        public bool CheckWin()
        {
            for (int i=0; i < velikost;i++)
            {
                for (int j=0; j < velikost; j++)
                {
                    if (lights[i, j])
                        return false;
                }
            }
            return true;
        }

        public void CheckEnd()
        {
            if (CheckWin() == true)
            {
                timer1.Stop();

                InicializacePole();

                MessageBox.Show("Hra byla úspěšně dokončena!",
                    "Blahopřejeme!");
            }
        }

        private void btn_sol_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    if (solution[i, j])
                    {
                        buttons[i, j].Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        buttons[i, j].ForeColor = System.Drawing.Color.PaleTurquoise;
                        buttons[i, j].Text = "J".Trim();
                        buttons[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    }
                }
            }
        }

        private void moves_count()
        {
            lbl_tahy.Text = String.Format("{0}", moves.ToString());
        }

    }
}
