using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public class Player
    {
        private string name; 
        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
                name = value;
            }
        }
        private string position;
        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Position can not be null or empty!");
                }
                position = value;
            }
        }
        public Player(string name, string position)
        {
            Name = name;
            Position = position;
        }
         
    }
}
