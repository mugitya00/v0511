namespace v0511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("����ɂ���");
            button1.Text = "�����ꂽ";
            button1.Left = 100;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible=false;
            button1 .Visible=true;
        }
    }
}