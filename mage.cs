using static System.Console;

public class mage : hero{

    
    public mage(string Name, int Level, string HeroType, int HP, int MP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP =  HP;
        this.MP = MP;

    }

    public override string Attack()
    {
        return this.Name + " " + "atacou com sua MAGIA"; 
    }

    public string Attack(int bonus)
    {
        return this.Name + " " + "atacou com sua MAGIA com bonus de amplificação mágica de" + " " + bonus;       
    }

    public override string ToString()
    {
        return this.Name + " " + this.Level + " " + this.HeroType + " " + "HP"+ " " + this.HP + " " + "MP"+ " " + this.MP;    
    }
}

