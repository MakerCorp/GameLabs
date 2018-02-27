using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameWind : Form
    {
        private Game game = new Game();

        public GameWind()
        {
            InitializeComponent();
        }



        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            game.startGraphics(g);
        }

        private void GameWind_FormClosing(object sender, FormClosingEventArgs e)
        {
            game.stopGame();
        }
    }
}
