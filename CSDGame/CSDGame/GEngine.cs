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

        private Bitmap texture_OrganTrailMan;

        /*-------------------Functions-------------------*/

        public GEngine(Graphics g)
        {
            drewHandle = g;
        }

        // Takes care of initializing all important things
        public void init()
        {
            // Start the render thread
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        // Loads resources
        private void LoadAssests()
        {
            OrganTrailMan = CSDGame.Properties.Resources.
        }

        // Stops the engine in it's tracks.
        public void stop()
        {
            renderThread.Abort();
        }

        // Runs indefinitely, drawing frame by frame.
        private void render()
        {
            int framesRendered = 0;
            long startTime = Environment.TickCount;

            Bitmap frame = new Bitmap(Game.CANVAS_HEIGHT, Game.CANVAS_HEIGHT);
            Graphics frameGraphics = Graphics.FromImage(frame);

            while (true)
            {

                // Background Color
                frameGraphics.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, Game.CANVAS_HEIGHT, Game.CANVAS_HEIGHT);

                // Draw the frame on the canvas
                drewHandle.DrawImage(frame, 0, 0);

                //Benchmaking
                framesRendered++;
                if ((Environment.TickCount) >= startTime + 1000)
                {
                    Console.WriteLine("GEngine: " + framesRendered + "fps");
                    framesRendered = 0;
                    startTime = Environment.TickCount;
                }
            }
        }
    }
}
