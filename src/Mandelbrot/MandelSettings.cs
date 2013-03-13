using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Mandelbrot
{
    [XmlRoot("MandelSettings")]
    public class MandelSettings
    {
        private double _sx, _sy, _fx, _fy = 0.0;
        private string _name = "Mandelbrot";
        private string _color = Application.StartupPath + "\\GreenEdge.COLORMAP";

        public MandelSettings()
        {
        }

        [XmlElement("color")]
        public string ColorFile
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        [XmlElement("name")]
        public string FractalName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        [XmlElement("sx")]
        public double StartX
        {
            get
            {
                return _sx;
            }
            set
            {
                _sx = value;
            }
        }

        [XmlElement("sy")]
        public double StartY
        {
            get
            {
                return _sy;
            }
            set
            {
                _sy = value;
            }
        }

        [XmlElement("fx")]
        public double FinishX
        {
            get
            {
                return _fx;
            }
            set
            {
                _fx = value;
            }
        }

        [XmlElement("fy")]
        public double FinishY
        {
            get
            {
                return _fy;
            }
            set
            {
                _fy = value;
            }
        }
    }
}
