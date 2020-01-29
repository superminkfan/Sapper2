using System;
using System.Windows.Forms;

namespace Sapper
{
    public partial class Sapper : Form
    {
        public Sapper()
        {
            InitializeComponent();
        }

        private void Eazy_Click(object sender, EventArgs e)
        {
           Hide();
           Game eazyGame = new Game(5);
           eazyGame.ShowDialog();
           Show();
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            Hide();
            Game normalGame = new Game(9);
            normalGame.ShowDialog();
            Show();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Hide();
            Game hardlGame = new Game(15);
            hardlGame.ShowDialog();
            Show();
        }
    }
}
