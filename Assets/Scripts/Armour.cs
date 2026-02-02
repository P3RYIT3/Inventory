using UnityEngine;

[CreateAssetMenu(fileName = "Armour", menuName = "Scriptable Objects/Armour")]

public class Armour: Item
{
    [SerializeField] protected int defenseValue;
    [SerializeField] protected string armourSlot;
    [SerializeField] protected string[] enchantment;
    [SerializeField] protected int condition;

    public int GetDefenseValue()
    {
        return defenseValue;
    }
    
    public string GetArmourSlot()
    {
        return armourSlot;
    }

    public string GetEnchantment()
    {
        return enchantment.ToString(); // ???????
    }
    
    public int GetCondition()
    {
        return condition;
    }

    public void RepairArmour(int repairValue)
    {
        condition += repairValue;
    }

    public void EquipArmour(string armourSlot)
    {
        //
    }
    
}
