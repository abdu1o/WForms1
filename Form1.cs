namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}