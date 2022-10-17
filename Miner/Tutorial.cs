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
    public partial class Tutorial : Form
    {
        private string tutorial = "Цель игры - открыть все поле, кроме спрятанных на нем бомб. Клик левой кнопкой мыши по любой клетке поля позволяет открыть  ее. С помощью клика правой кнопкой мыши можно можно поставить флажок, если вы уверены, что в этой клетке бомба, или нарисовать знак вопроса, если вы все еще сомневаетесь.\nЧисло в клетке означает, что где-то в соседней клетке спрятана бомба.Если это 'один' - в одной из клеток, которые касаются этой своей стороной или углом, есть бомба. Если 'два' - то в двух клетках, 'три' - в трех, и так далее.Отмечайте флажком заминированные клетки, и открывайте те, что считаете безопасными.И так до самого конца, пока все поле не будет безопасно. Удачи!";

        public Tutorial()
        {
            InitializeComponent();
            lblTutorial.Text = tutorial;   
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
