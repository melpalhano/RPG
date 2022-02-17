namespace rpg.src.Entities
{
    public class Wizard: Hero
    {
        public Wizard(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level; 
            this.Herotype = Herotype;
        }
        public override string Attack()
        {
            return this.Name + "Lançou Magia!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
                return this.Name + "Lançou uma super magia com bonus de " + Bonus;
            } else{
                return this.Name + "Lançou uma magia fraca com bonus de " + Bonus;
            }
            
        }
    }
}