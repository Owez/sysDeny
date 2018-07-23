using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace sysDeny
{
    public partial class FakeVirus : Form
    {
        public FakeVirus()
        {
            InitializeComponent();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\asset1.wav");
            player.PlayLooping();
        }
        
        private void FakeVirus_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
