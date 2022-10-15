using Miner.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class BattleField : Form
    {
        public int stage { get; set; }

        public BattleField(int level)
        {
            stage = level;
            SetLevel(level);
            InitializeComponent();
            //MapController.mapSize = 8;
            ConfigureMapSize();
            LoadImages(level);
            MapController.GetImage = getImage;
            InitField();
            
            panel_timer.Location = new Point(12, Height - 130);
            panel_flags.Location = new Point(211, Height - 130);
            TimerStart();
            MonitorFlags.Start();
            MapController.Endgame += TimerStop;
            MapController.Startgame += TimerStart;
            MapController.NextLevel += NextLevel;
        }

        private void SetLevel(int level)
        {
            if (level == 2)
            {
                MapController.mapSize = 10;
                MapController.bombNumber = 20;
            }
            else if (level == 3)
            {
                MapController.mapSize = 12;
                MapController.bombNumber = 40;
            }
            else
            {
                MapController.mapSize = 8;
                MapController.bombNumber = 12;
            }
        }

        private void ConfigureMapSize()
        {
            Width = MapController.mapSize * MapController.cellSize + 20;
            Height = (MapController.mapSize + 1) * MapController.cellSize + 15 + 110;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsDelete();
            InitField();
            TimerStop();
            TimerStart();
        }

        private void ControlsDelete()
        {
            if (Controls.Count > 1)
            {
                for (int i = 0; i < MapController.buttons.Length; i++)
                    Controls.RemoveAt(3);
            }
        }

        private void AProggramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра сапер. Разработана командой #4: Игорь, Дмитрий, Иван","О программе");
        }

        private void HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }
        private void InitField()
        {
            MapController.Init();
            for (int i = 0; i < MapController.mapSize; i++)
            {
                for (int j = 0; j < MapController.mapSize; j++)
                {
                    //Controls.Add(MapController.buttons[i, j]);
                    Controls.Add(MapController.panels[i, j]);

                }
            }
        }
        private void LoadImages(int lvl)
        {
            for (int i = 1; i <= 13; i ++)
            {
                imageList1.Images.Add(Image.FromFile(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString() + $"\\Sprites\\level{lvl}\\{i}.png"));
            }
        }
        public Image getImage(int i)
        {
            return imageList1.Images[i];
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapController.Restart();
            TimerStop();
            TimerStart();
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tutorial nextForm = new Tutorial();
            nextForm.ShowDialog();
        }

        private void PlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plot nextForm = new Plot();
            nextForm.ShowDialog();
        }

        //Code for the game timer
        private int seconds = 0;
        private const int timeLimit = 5999;

        public void TimerStart()
        {
            lblSeconds.Text = "0";
            lblMinutes.Text = "0";
            seconds = 0;
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            CountStart();
        }

        public void CountStart()
        {
            seconds++;
            int secondsDisplay = seconds % 60;
            lblSeconds.Text = secondsDisplay.ToString();
            if ((seconds / 60) > 0)
            {
                lblMinutes.Text = (seconds / 60).ToString();
            }

            if (seconds >= timeLimit)
            {
                TimerStop();
            }
        }

        public void TimerStop()
        {
            gameTimer.Stop();
        }

        private void MonitorFlags_Tick(object sender, EventArgs e)
        {
            lblFlags.Text = MapController.CountFlags().ToString();
        }


        private void NextLevel()
        {
            int lvl = 0;
            if (stage == 1)
                lvl = 2;
            else if (stage == 2)
                lvl = 3;
            else
                lvl = 1;

            if (stage < 3)
            {
                Level nextForm = new Level(lvl);
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                Finale nextForm = new Finale();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
        }

        private void buttonSkipLevel_Click(object sender, EventArgs e)
        {
            NextLevel();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
