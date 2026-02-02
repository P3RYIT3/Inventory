using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon")]

public class Weapon: Item
{
    [SerializeField] protected int damage;
    [SerializeField] protected string[] enchantment;
    [SerializeField] protected int attackSpeed;
    [SerializeField] protected double critDamage;
    [SerializeField] protected double critRate;
    [SerializeField] protected int condition;

    public int GetDamage()
    {
        return damage;
    }
    
    public string GetEnchantment()
    {
        return enchantment.ToString(); // ???????
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
    
    public int GetCondition()
    {
        return condition;
    }

    public double Attack()
    {
        double attackDamage = damage + (critRate * critDamage);
        return attackDamage;
    }

    public void RepairWeapon(int repairValue)
    {
        condition += repairValue;
    }
    
}

