using System;
using System.Windows.Forms;

namespace sysDeny
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        public void ShowForm()
        {
            FakeVirus fakeVirus = new FakeVirus();
            fakeVirus.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm();
        }
    }
}
