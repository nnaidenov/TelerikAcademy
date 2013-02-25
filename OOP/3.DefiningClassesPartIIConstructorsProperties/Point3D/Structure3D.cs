using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Structure3D
    {
        //Fields
        private int positionX;
        private int positionY;
        private int positionZ;

        public static readonly Structure3D Point0 = new Structure3D(0, 0, 0);
        //End Fields

        //Structures
        public Structure3D(int positionX, int positionY, int positionZ)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.positionZ = positionZ;
        }
        //End Structures

        //Properties
        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        public int PositionZ
        {
            get { return positionZ; }
            set { positionZ = value; }
        }

        //Methods

        //Override String()
        public override string ToString()
        {
            return String.Format("Point ({0}{1}{2})", positionX, positionY, positionZ);
        }
    }
}
