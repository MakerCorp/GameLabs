using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace WindowsFormsApplication1
{
    class GEngine
    {
        /*-------------------Members-------------------*/
        private Graphics drewHandle;
        private Thread renderThread;

        /*-------------------Functions-------------------*/

        public GEngine(Graphics g)
        {
            drewHandle = g;
        }

        public void init()
        {
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        public void stop()
        {
            renderThread.Abort();
        }

        private void render()
        {
            while (true)
            {
                drewHandle.FillRectangle(new SolidBrush(Color.Aqua) , 0, 0, 1200, 700);
            }
        }
    }
}
