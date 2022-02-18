public class knight : hero{


    public knight(string Name, int Level, string HeroType, int HP, int MP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP =  HP;
        this.MP = MP;

    }

    public virtual string Attack()
    {
        return this.Name + "Atacou com a espada";
    }

    public string Attack(int bonus)
    {
        return this.Name + " " + "atacou com sua ESPADA usando as duas mãos,dando um aumento de dano físico de" + " " + bonus;       
    }

    public override string ToString(){
        return this.Name + " " + this.Level + " " + this.HeroType + " " + "HP"+ " " + this.HP + " " + "MP"+ " " + this.MP;    
    }
}