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
    public partial class Level : Form
    {
        private int level = 1;
        private List<string> levelText = new List<string>()
        {
            "Подходя всё ближе к лесу, люди понимают почему его так назвали.\n Лес был неживой, только ледяной туман хозяйничал в нем. В таком лесу потеряться легче легкого. Того, кто потерялся в лесу, называли заблудшими. Именно из-за этой причины так начали называть лес. Ходят легенды, что заблудшие до сих пор пытаются найти выход с леса.\n Путники, заходя в туман, дальше своих рук ничего не видели. Мерлин предложил ориентироваться по веткам и камням, лежавшим на земле. Идея всем пришлась по душе. Собирая ветки и камни, путники продолжили свой путь.",
            "Отчаявшиеся и уставшие путники вдали видят очертание возвышения горы. С приподнятым духом и осознанием победы в маленькой миссии, они ускорили шаг и отправились к горе, где их ждет новое приключение.\n Перед входом в гору, находилось малочисленное паучье ополчение. Завидя войско, враг быстро ускользнул в расщелину в горе, чтобы принять бой на своих условиях.\n Маг придумал, как можно победить пауков, и поделился мыслью с королем. Артур выступил с речью перед подданными и поведал как можно разобраться с врагом. По окончанию речи, поступил приказ о разбитии лагеря и подготовки факелов. Выставив охрану и поставив факела на вход в гору, войны начали набираться сил, перед сильным врагом.\n После подготовки снаряжения, путешественники начали продвижения вглубь горы.",
            "Выйдя из туннеля, где виднелся свет, путники увидели подземное царство. Перед ними были ворота из толстого дерева, который были чуть-чуть приоткрыты. За ними был мертвый город, и только замок вдали подавал какие-то признаки жизни.\n Подойдя ближе, король увидел замок, выполненный из красного кирпича. У замка была башня, в которой горел свет. Он выглядел величественно и неприступно. Вокруг сооружения располагались стены, а под стенами находился ров с пустотой.\n Путники не видели защитников замка и без какого-либо сопротивления проникли внутрь.\n Зайдя в тронный зал замка, путников встретили массивные колонны, которые вели к трону. На троне восседал человек в фиолетовом балахоне, в левой руке держал посох с сияющим наконечником. Лица у повелителя подземного царства разглядеть не удалось, только его глаза сияли на темном фоне.\n Король потребовал у повелителя царства дочь. Человек в фиолетовом одеянии начал медленно подниматься. Когда он поднялся, начал невнятно что-то говорить. Из-под земли начали появляться монстры."
        };

        private List<string> formName = new List<string>()
        {
            "Лес заблудших",
            "Гора мертвых",
            "Boss"
        };

        public Level(int level)
        {
            this.level = level;
            InitializeComponent();
            labelLevel.Text = levelText[level - 1];
            this.Text = formName[level - 1];
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            BattleField nextForm = new BattleField(level);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
