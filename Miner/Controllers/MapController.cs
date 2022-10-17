using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner.Controllers
{
    public static class MapController
    {
        public delegate Image ReturnImage(int i);
        public static ReturnImage GetImage;
        public static int mapSize = 8;
        internal const int cellSize = 50;

        public static int[,] map;

        public static Button[,] buttons;
        public static Panel[,] panels;

        private static bool isFirstStep;

        private static Point firstCoord;

        public static int bombNumber;

        public static Form form;

        public static event Action Endgame;
        public static event Action Startgame;
        public static event Action NextLevel;

        internal static void Init()
        {
            buttons = new Button[mapSize, mapSize];
            panels = new Panel[mapSize, mapSize];
            map = new int[mapSize, mapSize];

        isFirstStep = true;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = 0;
                    Button button = new Button();
                    button.Size = new Size(cellSize, cellSize);
                    button.Image = GetImage(3);
                    button.MouseUp += new MouseEventHandler(OnButtonPressedMouse);
                    buttons[i, j] = button;


                    Panel panel = new Panel();
                    panel.Location = new Point(j * cellSize, 25 + i * cellSize);
                    panel.Size = new Size(cellSize, cellSize);
                    panel.BackgroundImage = GetImage(3);
                    panels[i, j] = panel;
                    panel.Controls.Add(button);
                }
            }
        }
        internal static void Restart()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    buttons[i, j].Visible = true;
                    panels[i, j].BackgroundImage = GetImage(3);
                    buttons[i, j].Image = GetImage(3);
                    buttons[i, j].BackColor = Color.White;
                }
            }

            Endgame?.Invoke();
            Startgame?.Invoke();
        }
        private static void OnButtonPressedMouse(object sender, MouseEventArgs e)
        {
            Button pressedButton = sender as Button;
            switch (e.Button.ToString())
            {
                case "Right":
                    OnRightButtonPressed(pressedButton);
                    break;
                case "Left":
                    OnLeftButtonPressed(pressedButton);
                    break;
            }
        }

        private static void OnRightButtonPressed(Button pressedButton)
        {
            if(pressedButton.BackColor == Color.Coral)
            {
                pressedButton.Image = GetImage(3);
                pressedButton.BackColor = Color.White;
                return;
            }
            pressedButton.Image = GetImage(0);
            pressedButton.BackColor = Color.Coral;
        }

        private static void OnLeftButtonPressed(Button pressedButton)
        {
            pressedButton.Visible = false;
            var panel = pressedButton.Parent as Panel;
            int iButton = panel.Location.Y / cellSize;
            int jButton = panel.Location.X / cellSize;
            if (isFirstStep)
            {
                
                firstCoord = new Point(jButton,iButton);
                SeedMap();
                CountCellBomb();               
                isFirstStep = false;
            }
            OpenCells(iButton, jButton);
            if (map[iButton, jButton] == -1)
            {
                ShowAllBombs(iButton,jButton);
                MessageBox.Show("Поражение!\nПопробуем еще разок.");
                Restart();
            }

            if (CheckFinish())
            {
                ShowAllBombs(iButton, jButton);
                MessageBox.Show("Победа!\nМожно двигаться дальше.");
                NextLevel?.Invoke();
            }
        }

        private static void ShowAllBombs(int iBomb,int jBomb)
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (i == iBomb && j == jBomb)
                        continue;
                    if(map[i, j] == -1)
                    {
                        panels[i, j].BackgroundImage = GetImage(1);
                        buttons[i, j].Visible = false;
                    }
                }
            }

            Endgame?.Invoke();
        }
        private static void SeedMap()
        {
            Random r = new Random();

            for(int i = 0; i < bombNumber; i++)
            {
                int posI = r.Next(0, mapSize - 1);
                int posJ = r.Next(0, mapSize - 1);

                while (map[posI, posJ] == -1 || (Math.Abs(posI-firstCoord.Y)<=1 && Math.Abs(posJ - firstCoord.X) <= 1))
                {
                    posI = r.Next(0, mapSize - 1);
                    posJ = r.Next(0, mapSize - 1);
                }
                map[posI, posJ] = -1;
            }
        }

        private static void CountCellBomb()
        {
            for(int i = 0; i < mapSize; i++)
            {
                for(int j = 0; j < mapSize; j++)
                {
                    if (map[i, j] == -1)
                    {
                        for(int k = i - 1; k < i + 2; k++)
                        {
                            for(int l = j - 1; l < j + 2; l++)
                            {
                                if (!IsInBorder(k, l) || map[k, l] == -1)
                                    continue;
                                map[k, l] = map[k, l] + 1;
                            }
                        }
                    }
                }
            }
        }

        private static void OpenCell(int i,int j)
        {
            buttons[i, j].Visible = false;

            switch (map[i, j])
            {
                case 1:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(4);
                    break;
                case 2:
                    buttons[i, j].Visible = false;
                    panels[i,j].BackgroundImage = GetImage(5);
                    break;
                case 3:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(6);
                    break;
                case 4:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(7);
                    break;
                case 5:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(8);
                    break;
                case 6:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(9);
                    break;
                case 7:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(10);
                    break;
                case 8:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(11);
                    break;
                case -1:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(1);
                    break;
                case 0:
                    buttons[i, j].Visible = false;
                    panels[i, j].BackgroundImage = GetImage(12);
                    break;
            }
        }

        private static void OpenCells(int i,int j)
        {
            OpenCell(i, j);

            if (map[i, j] > 0)
                return;

            for(int k = i - 1; k < i + 2; k++)
            {
                for(int l = j - 1; l < j + 2; l++)
                {
                    if (!IsInBorder(k, l))
                        continue;
                    if (!buttons[k, l].Visible)
                        continue;
                    if (map[k, l] >= 0)
                        OpenCells(k, l);
                }
            }
        }

        private static bool IsInBorder(int i,int j)
        {
            if(i<0 || j<0 || j>mapSize-1 || i > mapSize - 1)
            {
                return false;
            }
            return true;
        }

        public static int CountFlags()
        {
            int flagCount = 0;

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (buttons[i, j].BackColor == Color.Coral)
                    {
                        flagCount++;
                    }  
                }
            }
            
            return flagCount;
        }

        private static bool CheckFinish()
        {
            int countLeft = 0;

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (buttons[i, j].Visible)
                    {
                        countLeft++;
                    }
                }
            }

            if (countLeft == bombNumber)
            {
                return true;
            }

             return false;
        }

    }
}
