using System.Windows.Forms;

namespace Sapper
{
    public partial class Game : Form
    {
        public Game(int dim)
        {
            InitializeComponent();
            ClientSize = new System.Drawing.Size(dim * 41+30, dim * 41+40);
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(12, 31);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(dim * 41, dim * 41);
            panel.TabIndex = 1;
            Controls.Add(panel);
            field = new Field(dim, panel);
        }
    }
}
