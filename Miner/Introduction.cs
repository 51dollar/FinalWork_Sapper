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
            "В одном из королевств готовились к Хэллоуину. Вовсю наряжались дома и улицы. Семьи готовили костюмы для детей. Взрослые запасались сахарной провизией. Всё это проводилось для успешной защиты от монстров, ведьм, призраков, вампиров и других мифических существ.",
            "Среди белого дня раздался страшно громкий звук, который шёл с замка короля Артура. Люди, занимающимися своими делами, покидали все и устремились к замку. Дома опустели, на улицах можно было услышать шелест ветра. Все хотели знать: какая беда пришла к ним на кону праздника.",
            "Выбегает король со своей свитой. Лица не счесть, глаза выпучены, как будто смерть встретил, язык заплетаться, двух слов связать не может.",
            "Через какое-то время король все же начал приходит в себя и поведал о том, что произошло. Рассказанная история была словно из книги, появилось какое-то лихо в темном одеянии и забрало дочь Адду. Дочь короля считали символом празднества в королевстве. Адду уважали за ее способности устраивать праздники. Она выступала с пламенными речами, которые цепляли сердца людей. Адда часто любила сбегать из дворянского окружения и   веселилась с простым народом.",
            "Как только король пришел в себя, он отправил своих лучших разведчиков на поиски дочери. На следующий день, разведчики доложили предположительное местонахождение дочери. Адда находилось в пещере под горой мертвых в заблудшем лесу. Каждый из ныне живущий знал, что это место представляет опасность для любого смертного. Ходят легенды, что лес был проклят и теперь там живут мертвые. Но король не хотел сдаваться и подготовил рыцарей-освободителей. С ними еще волшебник Мерлин, правая рука короля, который всегда сопровождал Артура.",
            "С первыми петухами путешественники отправились в путь."
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
            Level nextForm = new Level(1);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
