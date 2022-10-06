using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class Plot : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Plot()
        {
            InitializeComponent();
            player.SoundLocation = "theme.wav";
            player.PlayLooping();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
