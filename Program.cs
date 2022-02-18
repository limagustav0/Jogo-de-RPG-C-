using static System.Console;

public class Program{

    static void Main(String[]args){

        knight arus = new knight("Arus",42,"knight",469, 749);
        mage mage = new mage("Jennica",42,"White Wizzard", 325, 574);
        ninja ninja = new ninja("Wedge",42, "Ninja", 292, 574);
        mage blackmage = new mage("Topapa", 42,"Black Wizzard", 106, 385);
        
        WriteLine(arus);
        WriteLine(mage);
        WriteLine(ninja);
        WriteLine(blackmage);

        WriteLine(arus.Attack(6));
        WriteLine(mage.Attack(4));
        WriteLine(ninja.Attack(2));
        WriteLine(blackmage.Attack(6));
    }

}