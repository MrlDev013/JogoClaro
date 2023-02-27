namespace JogoDeMover
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game();
            gameForm.Show();
            this.Hide();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}