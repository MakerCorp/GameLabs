using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Game
    {
        /*-------------------Constants-------------------*/
        public const int CANVAS_HEIGHT = 700;
        public const int CANVAS_WIDTH = 1200;

        /*-------------------Members-------------------*/
        private GEngine gEngine;

        // Launches the graphics engine
        public void startGraphics(Graphics g)
        {
            gEngine = new GEngine(g);
            gEngine.init();
        }

        // repondsible for ending all threads except the main application thread
        // prior to the window begin closed
        public void stopGame()
        {
            gEngine.stop();
        }
    }
}
