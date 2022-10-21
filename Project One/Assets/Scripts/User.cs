using System;

public class User
{
    private int HP;
    private int Attack;
    private float Speed;
    private int PotCount;

    public User()
    {
        //Default
        HP = 100;
        Attack = 20;
        Speed = 5.0f;
        PotCount = 2;
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
    public void setAttack(int newAttack)
    {
        Attack = newAttack;
    }

    //Speed
    public float getSpeed()
    {
        return Speed;
    }
    public void setSpeed(float newSpeed)
    {
        Speed = newSpeed;
    }

    //PotCount
    public int getPot()
    {
        return PotCount;
    }
    public void setPot(int newCount)
    {
        PotCount = newCount;
    }
}
