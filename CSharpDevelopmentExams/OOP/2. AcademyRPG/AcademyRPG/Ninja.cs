using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private int TimesStone { get; set; }
        private int TimesLumber { get; set; }
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get
            {
                return HitPoints;
            }
            set
            {
                    this.HitPoints += TimesLumber+TimesStone;

            }
        }

        public int DefensePoints
        {
            get { return 100; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            List<WorldObject> someTarget = new List<WorldObject>();
           
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    someTarget.Add(availableTargets[i]);
                    return i;
                }
            }

           

            if (someTarget.Count != 0)
            {
                var sortLAMBDA = someTarget.OrderByDescending(student => student.HitPoints);
                List<int> asdf = new List<int>();
                asdf.Add((sortLAMBDA as WorldObject).Owner);
                return asdf[0];
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.TimesLumber += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.TimesStone += resource.Quantity*2;
                return true;
            }
            return false;
        }
    }
}
