namespace ShapeTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get { return this.width; }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("width: {0} height: {1}", this.width, this.height);
        }
    }
}
