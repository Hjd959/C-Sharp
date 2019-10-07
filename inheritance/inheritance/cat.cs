using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    public class cat : anymal
    {
        //internal object cat;

        public int weight
        {
            get;
            set;
           
        }

        public int color
        {
            get;
            set;
           
        }

        public string getNameAndType()
        {
            return ($" type is {type }, weight is { this.weight } and color is { this.color} ");
        }
    }
}