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
        public static int difficulty = 8;
        public static int mapSize = difficulty;
        internal const int cellSize = 50;

        public static int[,] map = new int[mapSize, mapSize];

        public static Button[,] buttons = new Button[mapSize, mapSize];

        private static bool isFirstStep;

        private static Point firstCoord;

        private static int number;

        public static Form form;

        internal static void Init()
        {
            isFirstStep = true;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = 0;
                    Button button = new Button();
                    button.Location = new Point(j * cellSize,25 + i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.Image = GetImage(3);
                    button.MouseUp += new MouseEventHandler(OnButtonPressedMouse);
                    buttons[i, j] = button;
                }
            }
        }
        internal static void Restart()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Image = GetImage(3);
                    buttons[i, j].BackColor = Color.White;
                }

            }
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
            pressedButton.Enabled = false;
            //pressedButton.BackColor = Color.White;
            int iButton = pressedButton.Location.Y / cellSize;
            int jButton = pressedButton.Location.X / cellSize;
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
                MessageBox.Show("Поражение!");
                Restart();
            }

            if (CheckFinish())
            {
                ShowAllBombs(iButton, jButton);
                MessageBox.Show("Победа!");
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
                        buttons[i, j].Image = GetImage(1);
                    }
                }
            }
        }
        private static void SeedMap()
        {
            Random r = new Random();
            number = r.Next(7, 15);

            for(int i = 0; i < number; i++)
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
            buttons[i, j].Enabled = false;

            switch (map[i, j])
            {
                case 1:
                    buttons[i, j].Image = GetImage(4);
                    break;
                case 2:
                    buttons[i, j].Image = GetImage(5);
                    break;
                case 3:
                    buttons[i, j].Image = GetImage(6);
                    break;
                case 4:
                    buttons[i, j].Image = GetImage(7);
                    break;
                case 5:
                    buttons[i, j].Image = GetImage(8);
                    break;
                case 6:
                    buttons[i, j].Image = GetImage(9);
                    break;
                case 7:
                    buttons[i, j].Image = GetImage(10);
                    break;
                case 8:
                    buttons[i, j].Image = GetImage(11);
                    break;
                case -1:
                    buttons[i, j].Image = GetImage(1);
                    break;
                case 0:
                    buttons[i, j].Image = GetImage(12);
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
                    if (!buttons[k, l].Enabled)
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
                    if (buttons[i, j].Enabled)
                    {
                        countLeft++;
                    }
                }
            }

            if (countLeft == number)
            {
                return true;
            }

             return false;
        }

    }
}
