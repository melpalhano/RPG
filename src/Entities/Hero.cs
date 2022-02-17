namespace rpg.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level; 
            this.Herotype = Herotype;            
        }
        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string Herotype;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Herotype;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada!";

        }
    }
}