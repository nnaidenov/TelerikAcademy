using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Disciplines : Comments
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (name != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set 
            {
                if (value >= 0)
                {
                    this.numberOfLectures = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set 
            {
                if (value >= 0)
                {
                    this.numberOfExercises = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
