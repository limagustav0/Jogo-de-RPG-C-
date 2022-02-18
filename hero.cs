using static System.Console;

public class hero{

    public virtual string Attack()
    {
        return this.Name + "Atacou com a espada";
    }

    public hero(string Name, int Level, string HeroType, int HP, int MP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP =  HP;
        this.MP = MP;

    }
    public hero()
	        {
	            
	        }
    public string Name;
    public int Level;
    public string HeroType;
    public int HP;
    public int MP;

}