using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon")]

public class Weapon: Equipment
{
    [SerializeField] protected int damage;
    [SerializeField] protected int attackSpeed;
    [SerializeField] protected double critDamage;
    [SerializeField] protected double critRate;

    public int GetDamage()
    {
        return damage;
    }

    public int GetAttackSpeed()
    {
        return attackSpeed;
    }

    public double GetCritDamage()
    {
        return critDamage;
    }

    public double GetCritRate()
    {
        return critRate;
    }

    public double Attack()
    {
        double attackDamage = damage + (critRate * critDamage);
        return attackDamage;
    }
    
}

