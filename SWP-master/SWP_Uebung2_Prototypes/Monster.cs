using System;

namespace SWP_Uebung2_Prototypes
{
    public class Monster:ICloneable
    {
        public string name { get; set; }
        public int hitpoints { get; set; }
        public int speed { get; set; }
        public string fear { get; set; }
        public int type { get; set; }
        public string color { get; set; }
        public int attackpoints { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return "name: "+name +" hitpoints: " + hitpoints + " speed: " + speed + " fear: " + fear + " type: " + type + " color: " + color + " attackpoints: " + attackpoints;
        }
    }
}