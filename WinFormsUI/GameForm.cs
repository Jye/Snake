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
        public GameForm()
        {
            InitializeComponent();
            var game = new Model.Game(50, 50);

        }
    }
}
