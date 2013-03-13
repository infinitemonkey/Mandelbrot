using System;
using System.Collections.Generic;
using System.Text;

namespace Mandelbrot
{
    class Calculation
    {
        private int _s;
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int S
        {
            get { return _s; }
            set { _s = value; }
        }

        public void Zeilen()
        {
            double x, y, x1, y1, xx, xmin, xmax, ymin, ymax = 0.0;
            int looper, s, z = 0;
            y = ymin;
            for (z = 1; z < this.Height; z++)
            {
                x1 = 0;
                y1 = 0;
                looper = 0;
                while (looper < 100 && Math.Sqrt((x1 * x1) + (y1 * y1)) < 2)
                {
                    looper++;
                    xx = (x1 * x1) - (y1 * y1) + x;
                    y1 = 2 * x1 * y1 + y;
                    x1 = xx;
                }

                // Get the percent of where the looper stopped
                double perc = looper / (100.0);
                // Get that part of a 255 scale
                int val = ((int)(perc * 255));
                // Use that number to set the color
                b.SetPixel(_s, z, cs[val]);
                y += intigralY;
            }
        }
        
    }
}
