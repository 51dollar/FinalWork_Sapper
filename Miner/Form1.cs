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
            ConfigureMapSize();
            LoadImages();
            MapController.GetImage = getImage;
            MapController.Init(this);
        }
        private void ConfigureMapSize()
        {
            Width = MapController.mapSize * MapController.cellSize + 20;
            Height = (MapController.mapSize + 1) * MapController.cellSize + 15;
        }
        private void AProggramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра сапер. Разработана командой #4: Игорь, Дмитрий, Иван");
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
        }
    }
}
