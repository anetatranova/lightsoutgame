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
    public partial class _7x7_okno : Form
    {
        //inicializace potřebných datových struktur a proměnných hodnot

        public Button[,] buttons = new Button[7, 7];
        public int velikost = 7;
        public bool[,] lights = new bool[7,7];

        public bool[,] solution = new bool[7, 7];

        int timeMin, timeSec;
        int a, b;

        public int moves;

        public _7x7_okno()
        {
            buttons = new Button[7, 7] { {btn_11,btn_12, btn_13, btn_14, btn_15, btn_16, btn_17 },
                { btn_21, btn_22, btn_23, btn_24, btn_25, btn_26, btn_27},
                { btn_31, btn_32, btn_33, btn_34, btn_35, btn_36, btn_37},
                {btn_41, btn_42, btn_43, btn_44, btn_45, btn_46, btn_47 },
                {btn_51, btn_52, btn_53, btn_54, btn_55, btn_56, btn_57 },
                {btn_61, btn_62, btn_63, btn_64, btn_65, btn_66, btn_67 },
                {btn_71, btn_72, btn_73, btn_74, btn_75, btn_76, btn_77 }};
            InitializeComponent();
            InicializacePole();
        }

        //tady nastavujeme výchozí nastavení hracího pole

        public void InicializacePole()
        {
            buttons = new Button[7, 7] { {btn_11,btn_12, btn_13, btn_14, btn_15, btn_16, btn_17 },
                { btn_21, btn_22, btn_23, btn_24, btn_25, btn_26, btn_27},
                { btn_31, btn_32, btn_33, btn_34, btn_35, btn_36, btn_37},
                {btn_41, btn_42, btn_43, btn_44, btn_45, btn_46, btn_47 },
                {btn_51, btn_52, btn_53, btn_54, btn_55, btn_56, btn_57 },
                {btn_61, btn_62, btn_63, btn_64, btn_65, btn_66, btn_67 },
                {btn_71, btn_72, btn_73, btn_74, btn_75, btn_76, btn_77 }};

            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    buttons[i, j].Name = "X: " + i + " " + "Y: " + j;
                    buttons[i, j].BackColor = Color.DarkBlue;               //světlo je ve výchozím nastavení zhasnuté
                    buttons[i, j].Enabled = false;                          //chceme zamezit interakci hráče s hracími tlačítky dokud nezáhájí hru
                    buttons[i, j].Text = "";
                    lights[i, j] = false;                                   //všechna světla jsou zhasnutá
                    solution[i, j] = false;                                 //není zatím žádné řešení
                    moves = 0;
                }
            }

        }

        //metoda pro kliknutí na světlo

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int x = int.Parse(button.Name.Split()[1]);
            int y = int.Parse(button.Name.Split()[3]);
            toggleLight(buttons[x, y], x, y);                           //rozvícení/zhasnutí světel

            moves++;                                                    //počet tahů
            moves_count();

            solution[x, y] = !solution[x, y];                           //řešení - pokud hráč klikl na spravné světlo, změní se jeho hodnota na false a naopak

            if (solution[x, y] == false)
                buttons[x, y].Text = "";

            CheckEnd();                                                 //kontrola výhry
        }

        //zahájení hry

        private void start_Click(object sender, EventArgs e)
        {
            InicializacePole();
            foreach (Button btn in buttons)                             //povolujeme interakci hráče se světly
                btn.Enabled = true;
            ResetTime();                                                //resetujeme měření času
            moves_count();                                              //resetujeme počet tahů
            timer1.Start();                                             //začínáme měřit čas
            Start();                                                    //generujeme hrací pole
        }

        //nastavujeme stopky na nulu

        private void ResetTime()
        {
            timeMin = 0;
            timeSec = 0;
            a = timeSec;
            b = timeMin;
        }

        //měření času na minuty a sekundy

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

        //metoda měnící stav jednoho světla

        public void switchLight(object sender, int x, int y)
        {
            lights[x, y] = !lights[x, y];

            if (lights[x, y])
                buttons[x, y].BackColor = Color.Yellow;
            else
                buttons[x, y].BackColor = Color.DarkBlue;
        }

        //metoda měnící stav světel při jednom kliknutí

        public void toggleLight(object sender, int x, int y)
        {
            switchLight(buttons[x, y], x, y);                               //zvolené světlo

            if (x < velikost - 1)                                           //nad
                switchLight(buttons[x + 1, y], x + 1, y);
            if (x > 0)                                                      //pod 
                switchLight(buttons[x - 1, y], x - 1, y);
            if (y < velikost - 1)                                           //napravo
                switchLight(buttons[x, y + 1], x, y + 1);
            if (y > 0)                                                      //nalevo
                switchLight(buttons[x, y - 1], x, y - 1);

        }

        //metoda generující náhodné hrací pole

        public void Start()
        {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(velikost, velikost * velikost); i++)     //počet
            {
                int x = rnd.Next(0, velikost - 1);                              //výběr souřadnic
                int y = rnd.Next(0, velikost - 1);
                toggleLight(buttons[x, y], x, y);

                solution[x, y] = !solution[x, y];                                 //zvolené světlo se zapíše do pole solution
            }

            if (CheckWin() == true)                                             //kontrola zda vygenerované pole není celé zhasnuté
            {
                Start();
            }

        }

        //kotrolní metoda zda pole není celé zhasnuté

        public bool CheckWin()
        {
            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    if (lights[i, j])
                        return false;
                }
            }
            return true;
        }

        //metoda pro výhru

        public void CheckEnd()
        {
            if (CheckWin() == true)
            {
                timer1.Stop();

                InicializacePole();         //výchozí nastavení

                MessageBox.Show("Hra byla úspěšně dokončena!",
                    "Blahopřejeme!");
            }
        }

        //metoda pro zobrazení řešení

        private void btn_sol_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    if (solution[i, j])         //pokud má políčko v poli solution true hodnotu, zobrazí se na korespondujícím světle smajlík
                    {
                        buttons[i, j].Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        buttons[i, j].ForeColor = System.Drawing.Color.PaleTurquoise;
                        buttons[i, j].Text = "J".Trim();
                        buttons[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    }
                }
            }
        }

        //metoda vypisující počet tahů

        private void moves_count()
        {
            lbl_tahy.Text = String.Format("{0}", moves.ToString());
        }

    }
}