// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100.
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. 
    // The damage done should be 3 * strength (3 points of damage to the attacked, for each 1 point of strength of the attacker). 
    // This method should return the remaining health of the target object.
    public int Attack(Human target)
    {
        int damage = Strength * 3;
        target.Health -= damage;
        return target.Health;
    }
}

