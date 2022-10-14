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
    public partial class Introduction : Form
    {
        int page = 1;
        public Introduction()
        {
            InitializeComponent();
            DisplayText();
        }

        private List<string> introduction = new List<string>() 
        {
            "В одном из королевств готовились к Хэллоуину. Вовсю наряжались дома, улицы, готовились костюмы для детей, запасались сахарной провизией, для успешной защиты: от монстров, ведьм, призраков, вампиров и других мифических существ.",
            "Среди белого дня раздался страшно громкий звук, шёл он с замка сурового короля Артура, который был прекрасным воителем и одержал множество побед, но и так же врагов нашел, но даже так короля любили и уважали. Народ, который услышал страшный звук (занимался своей работой), покидали все свои дела и устремились к замку. Дома опустели, на улицах можно было услышать шелест ветра. Все хотели знать, какая беда пришла к ним на кону праздника.",
            "Выбегает король со своим войском. Лица не счесть, глаза выпучены, как будто смерть встретил, язык заплетаться, что двух слов связать не может.  ",
            "Через какое-то время король все же пришел в себя и начал рассказывать что произошло. Рассказанная история была как будто из книги, появилось какое-то лихо в черном одеянии и забрало дочь Адду. Дочь короля считалась символом празднества в королевстве. Адда устраивала все праздники, выступала с пламенными речами, которые забирали сердца людей и нередко Адда вырывалась из дворянского окружения и   веселилась с простым народом.",
            "Король отправил своих лучших разведчиков на поиски дочери. На следующий день, разведчики дали предположительное местонахождение дочери. Адда находилось в пещере под горой мертвых, который находился в заблудшем лесу, каждый живущий знал, что это место представляет опасность для любого смертного. Но король не хотел сдаваться и подготовил рыцарей-освободителей, к ним присоединился крестьянин, оруженосец Мерлин и отправились они в путь."
        };

        private void buttonForward_Click(object sender, EventArgs e)
        {
            page++;
            DisplayText();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            page--;
            DisplayText();
        }

        private void DisplayText()
        {
            labelIntroduction.Text = introduction[page - 1];
            if (page <= 1)
            {
                buttonBack.Visible = false;
                buttonForward.Visible = true;
            }
            else if (page > 1 && page < introduction.Count)
            {
                buttonBack.Visible = true;
                buttonForward.Visible = true;
            }
            else if (page >= introduction.Count)
            {
                buttonBack.Visible = true;
                buttonForward.Visible = false;
            }

            labelIntroduction.Text = introduction[page - 1];
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            Level1 nextForm = new Level1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
