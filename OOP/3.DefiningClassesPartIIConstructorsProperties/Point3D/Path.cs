using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        //Fields
        private List<Structure3D> sequenceOfPoints = new List<Structure3D>();
        //End Fields

        //Properties
        public List<Structure3D> Paths
        {
            get { return sequenceOfPoints; }
        }

        //Methods
        public void AddPoint(Structure3D point)
        {
            sequenceOfPoints.Add(point);
        }

        public void ClearPoints()
        {
            sequenceOfPoints.Clear();
        }
    }
}
