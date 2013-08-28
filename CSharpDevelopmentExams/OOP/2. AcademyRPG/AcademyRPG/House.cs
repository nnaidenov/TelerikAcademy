using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class House : StaticObject
    {
        protected int Owner { get; private set; }

        public ResourceType Type 
        { 
            get 
            { 
                return ResourceType.Lumber; 
            } 
        }

        public int Quantity
        {
            get
            {
              return  this.HitPoints;
            }
        }

        public House(Point position, int owner)
            : base(position)
        {
            this.HitPoints = 500;
            this.Owner = owner;
        }
    }
}
