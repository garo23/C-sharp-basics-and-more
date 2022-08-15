using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAnimals
{
    public abstract class Animals
    {
        public int Age;
        public string Name;
        public string Gender;

        public Animals() { }

        public virtual int age
        {
            get { return Age; }
            set
            {

                if (value < 0 && value > 100)
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid age");
                }
                Age = value;
            }
        }

        public virtual string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public virtual string gender
        {
            get { return Gender;}
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentOutOfRangeException("Please enter valid Gender");
                }
                { Gender = value; }
            }
        }
        public abstract void GetSound();
       
        
    }
    
}
