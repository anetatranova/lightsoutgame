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
    }
}