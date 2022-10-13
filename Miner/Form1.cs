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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MapController.difficulty = 10;
            ConfigureMapSize();
            LoadImages();
            MapController.GetImage = getImage;
            InitField();
            
            panel_timer.Location = new Point(12, Height - 130);
            panel_flags.Location = new Point(211, Height - 130);
            TimerStart();
            MonitorFlags.Start();
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
                    Controls.Add(MapController.buttons[i, j]);

                }
            }
        }
        private void LoadImages()
        {
            for (int i = 1; i <= 13; i ++)
            {
                imageList1.Images.Add(Image.FromFile(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString() + $"\\Sprites\\{i}.png"));
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

    }
}
