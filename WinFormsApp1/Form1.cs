namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "welcom";
            this.ForeColor = Color.Green;
            this.Size = new(200, 300);
            this.MaximumSize = new(800, 800);
            this.MinimumSize = new(300, 300);
            this.Enabled = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "text";
            textBox1.Multiline = true;
            textBox1.ForeColor = Color.Gray;
            textBox1.PasswordChar = '*';


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(20, 10);
            button1.Location = new Point(60, 90);
            button1.Enabled = true;
            button1.Visible = false;
            button1.Hide();
            button1.Show();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoScroll = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = "hhhh";


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;


        }
    }
}
