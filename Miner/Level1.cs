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
    public partial class Level1 : Form
    {
        string level1Story = "Лес был словно неживой, ни травки, ни животных, только ледяной туман, который пробирает до костей. Если зайдешь в туман без знания, как из него выйти, то тебя считали заблудшим, по этому лес и называется «заблудшим», в него заходят и не выбираются больше. По легендам, там еще гуляют их души или то, что от них осталось. Король Артур, заходя в лес, ориентируется по камушкам и веткам, лежащим на земле, это единственное, что видно в жутком тумане.";

        public Level1()
        {
            InitializeComponent();
            labelLevel1.Text = level1Story;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1(1);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
