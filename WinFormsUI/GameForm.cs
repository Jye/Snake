using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class GameForm : Form
    {
        Model game;
        public GameForm()
        {
            InitializeComponent();
            game = new Model.Game(50, 50);
            gamePanel.Paint += gamePanel_Paint;
        }

        void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < game.Rows; x++)
            {
                for (int y = 0; y < game.Columns; y++)
                {

                }
            }
        }
    }
}
