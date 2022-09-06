namespace LIGHTSOUT2
{
    public partial class hlavni_okno : Form
    {
        public hlavni_okno()
        {
            InitializeComponent();
        }

        private void btn_hrathru_Click(object sender, EventArgs e)
        {
            pole_okno pole_Okno = new pole_okno();
            pole_Okno.Show();
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            manual_okno manual_Okno = new manual_okno();
            manual_Okno.Show();
        }
    }
}