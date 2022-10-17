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
    public partial class Finale : Form
    {
        public Finale()
        {
            InitializeComponent();
            lblFinale.Text = finaleText;
        }

        private string finaleText = "В неравном бою маг пал, а с ним и его приспешники.\n Поднявшись в башню, Мерлин снимает магические оковы с девушки. Путники готовятся к возвращению.\n Вернувшись в королевство, их встречают радостные жители. Адда вспомнив про праздник, начала быстро набрасывать возможные варианты проведения незабываемого праздника. Уже на следующий день, все было готово.\n С вашей помощью удалось спасти Адду и праздник выдался на славу!";

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Level nextForm = new Level(1);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
