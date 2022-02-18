public class ninja : hero
{
    public ninja(string Name, int Level, string HeroType, int HP, int MP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP =  HP;
        this.MP = MP;

    }
    public ninja()
	        {
	            
	        }
    public string Name;
    public int Level;
    public string HeroType;
    public int HP;
    public int MP;

    public override string ToString(){
        return this.Name + " " + this.Level + " " + this.HeroType + " " + "HP"+ " " + this.HP + " " + "MP"+ " " + this.MP;    
    }

    public virtual string Attack()
    {
        return this.Name + "Atacou com a sua Kunai";
    }

    public string Attack(int bonus)
    {
        return this.Name + " " + "atacou usando seu Jutsu de fogo,dando um aumento de dano de queimadura de" + " " + bonus;       
    }
}