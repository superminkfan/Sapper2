using System;
using System.Linq;
using System.Windows.Forms;

namespace Sapper
{
    public class Field
    {
        public Button[,] ButtonArray;
        public Status[,] array;
        int dimension;
        public Field(int dimension, Panel panel)
        {
            this.dimension = dimension;
            ButtonArray = new Button[dimension, dimension];
            for (int i = 1; i <= dimension; i++)
            {
                for (int j = 1; j <= dimension; j++)
                {
                    ButtonArray[i - 1, j - 1] = new Button();
                    ButtonArray[i - 1, j - 1].BackColor = System.Drawing.SystemColors.ControlDark;
                    ButtonArray[i - 1, j - 1].FlatAppearance.BorderSize = 0;
                    ButtonArray[i - 1, j - 1].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ButtonArray[i - 1, j - 1].Location = new System.Drawing.Point((i - 1) * 41, (j - 1) * 41);
                    ButtonArray[i - 1, j - 1].Margin = new System.Windows.Forms.Padding(1);
                    ButtonArray[i - 1, j - 1].Name = "Button" + ((i) + dimension * (j - 1)).ToString();
                    ButtonArray[i - 1, j - 1].Size = new System.Drawing.Size(40, 40);
                    ButtonArray[i - 1, j - 1].UseVisualStyleBackColor = false;
                    ButtonArray[i - 1, j - 1].MouseDown += new MouseEventHandler(this.Check);  
                    panel.Controls.Add(ButtonArray[i - 1, j - 1]);
                }
            }
            array = new Status[dimension, dimension];
            for (int n = 0; n < dimension; n++)
            {
                for(int m = 0; m < dimension; m++)
                array[n,m] = 0;
            }
           Random rnd = new Random();
            for (int c = 0; c < dimension*dimension/6; c++)
                array[rnd.Next(dimension - 1), rnd.Next(dimension - 1)] = Status.Bomb;
        }
        private int SabCheck(int x, int y)
        {
            int count = 0;
            if (x == 0)
            {
                if (y == 0)
                {
                    for (int i = x; i <= x + 1; i++)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            if (array[i, j] == Status.Bomb)
                            {
                                count++;
                            }
                        }
                    }
                }
                if (y == dimension - 1)
                {
                    for (int i = x; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y; j++)
                        {
                            if (array[i, j] == Status.Bomb)
                            {
                                count++;
                            }
                        }
                    }
                }
                if (y != 0 && y != dimension - 1)
                {
                    for (int i = x; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (array[i, j] == Status.Bomb)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (x == dimension - 1)
            {
                if (y == 0)
                {
                    for (int i = x - 1; i <= x; i++)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            if (array[i, j] == Status.Bomb)
                            {
                                count++;
                            }
                        }
                    }
                }
                if (y == dimension - 1)
                {
                    for (int i = x - 1; i <= x; i++)
                    {
                        for (int j = y - 1; j <= y; j++)
                        {
                            if (array[i, j] == Status.Bomb)
                            {
                                count++;
                            }
                        }
                    }
                }
                if (y != 0 && y != dimension - 1)
                {
                    for (int i = x - 1; i <= x; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (array[i, j] == Status.Bomb)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (y == 0 && x != 0 && x != dimension - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y; j <= y + 1; j++)
                    {
                        if (array[i, j] == Status.Bomb)
                        {
                            count++;
                        }
                    }
                }
            }
            if (y == dimension-1 && x != 0 && x != dimension - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y; j++)
                    {
                        if (array[i, j] == Status.Bomb)
                        {
                            count++;
                        }
                    }
                }
            }
            if (x != 0 && x != dimension - 1 && y != 0 && y != dimension - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (array[i, j] == Status.Bomb)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        private void SabClick(int x, int y)
        {
            if (x == 0)
            {
                if (y == 0)
                {
                    for (int i = x; i <= x + 1; i++)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            MethodForClick(i, j, x, y);
                        }
                    }
                }
                if (y == dimension - 1)
                {
                    for (int i = x; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y; j++)
                        {
                            MethodForClick(i, j, x, y);
                        }
                    }
                }
                if (y != 0 && y != dimension - 1)
                {
                    for (int i = x; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            MethodForClick(i, j, x, y);
                        }
                    }
                }
            }
            if (x == dimension - 1)
            {
                if (y == 0)
                {
                    for (int i = x - 1; i <= x; i++)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            MethodForClick(i, j, x, y);
                        }
                    }
                }
                if (y == dimension - 1)
                {
                    for (int i = x - 1; i <= x; i++)
                    {
                        for (int j = y - 1; j <= y; j++)
                        {
                            MethodForClick(i, j, x, y);
                        }
                    }
                }
                if (y != 0 && y != dimension - 1)
                {
                    for (int i = x - 1; i <= x; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            MethodForClick(i, j, x, y);
                        }
                    }
                }
            }
            if (y == 0 && x != 0 && x != dimension - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y; j <= y + 1; j++)
                    {
                        MethodForClick(i, j, x, y);
                    }
                }
            }
            if (y == dimension - 1 && x != 0 && x != dimension - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y; j++)
                    {
                        MethodForClick(i, j, x, y);
                    }
                }
            }
            if (x != 0 && x != dimension - 1 && y != 0 && y != dimension - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        MethodForClick(i, j, x, y);
                    }
                }
            }
        }
        private void MethodForClick(int i, int j, int x, int y)
        {
            int count = 0;
            if (array[i, j] != Status.Bomb)
            {
                count = SabCheck(i, j);
                ButtonArray[i, j].Text = count.ToString();
                ButtonArray[i, j].BackColor = System.Drawing.Color.Green;
                if (x != i || y != j)
                {
                    if (count == 0 && array[i, j] != Status.Checked)
                    {
                        array[i, j] = Status.Checked;
                        SabClick(i, j);
                    }
                }
            }
        }
        public void Check(object sender, MouseEventArgs e)
        {
            if ((sender as Button).Text == String.Empty)
            {
                if (e.Button == MouseButtons.Left)
                { 
                    string d = (sender as Button).Name.ToString();
                    int d1 = Convert.ToInt32(d.Split('n').ToArray()[1]);
                    int y = (d1 - 1) / dimension;
                    int x = (d1 - 1) % dimension;
                    if (array[x, y] == Status.Unknown)
                    {
                        array[x, y] = Status.Checked;
                        int count = SabCheck(x, y);
                        (sender as Button).Text = count.ToString();
                        (sender as Button).BackColor = System.Drawing.Color.Green;
                        if (count == 0)
                            SabClick(x, y);
                        bool value = true;
                        for (int i = 0; i <= dimension - 1; i++)
                        {
                            for (int j = 0; j <= dimension - 1; j++)
                            {
                                if (array[i, j] != Status.Bomb)
                                    value = value && ButtonArray[i, j].Text != String.Empty;
                            }
                        }
                        if (value)
                        {
                            MessageBox.Show("Вы нашли все мины!", "Победа", MessageBoxButtons.OK);
                            Game.ActiveForm.Close();
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= dimension - 1; i++)
                        {
                            for (int j = 0; j <= dimension - 1; j++)
                            {
                                if (array[i, j] == Status.Bomb)
                                    ButtonArray[i, j].BackColor = System.Drawing.Color.Red;
                            }
                        }
                        MessageBox.Show("Вы взорвались!", "Проигрыш", MessageBoxButtons.OK);
                        Game.ActiveForm.Close();
                    }
                }
                else
                {
                    if ((sender as Button).BackColor != System.Drawing.Color.Cyan)
                        (sender as Button).BackColor = System.Drawing.Color.Cyan;
                    else
                        (sender as Button).BackColor = System.Drawing.SystemColors.ControlDark;
                }
            }
           
        }
    }
}
