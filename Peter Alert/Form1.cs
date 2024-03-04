using System.Diagnostics;

namespace Peter_Alert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

// Hey Lois, I'm in Visual Studio

// August, 2023
