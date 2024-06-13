using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasove
{
    internal class Rectangle
    {
        private int width;
        private int height;
        private string color;
        public int Height
        {
            get { return height; }
            set { this.height = value; }
        }
        public int weigth
        {
            get { return width; }
            set { this.width = value; }
        }
        public string Color
        {
            get { return color; }
            set { this.color = value; }

        }
        public Rectangle(int width, int height, string color)
        {
            this.width = width;
            this.height = height;
            this.color = color;
        }
    }
}
