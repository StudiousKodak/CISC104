using System;

public class Enemy
{
    private int HP;
    private int Attack;
    private float Speed;
    private String Name;
    private String Item;

    public Enemy()
    {
        //Default (Goblin)
        HP = 20;
        Attack = 10;
        Speed = 4.0f;
        Name = "Goblin";
        Item = "Goblins Pouch";
    }

    public Enemy(int newHP, int newAttack, float newSpeed, String newName, String newItem)
    {
        // Anything Else (Brute)
        HP = newHP;
        Attack = newAttack;
        Speed = newSpeed;
        Name = newName;
        Item = newItem;
    }

    //HP
    public int getHP()
    {
        return HP;
    }
    public void setHP(int newHP)
    {
        HP = newHP;
    }

    //Attack
    public int getAttack()
    {
        return Attack;
    }

    //Speed
    public float getSpeed()
    {
        return Speed;
    }

    //Name
    public String getName()
    {
        return Name;
    }

    //Item
    public String getItem()
    {
        return Item;
    }
}


