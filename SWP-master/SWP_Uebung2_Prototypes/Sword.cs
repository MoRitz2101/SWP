namespace SWP_Uebung2_Prototypes
{
    public class Sword
    {
        public string name { get; set; }
        public double damage { get; set; }
        public double defense { get; set; }
        public double magic { get; set; }
        public double price { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return "name: " + name + " damage: " + damage + " defense: " + defense + " magic: " + magic + " price: " + price;
        }
    }
}