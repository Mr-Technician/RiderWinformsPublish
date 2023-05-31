namespace RiderWinformsPublish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if DEBUG
            textBox1.Text = "DEBUG";
#else
            textBox1.Text = "RELEASE";
#endif
        }
    }
}