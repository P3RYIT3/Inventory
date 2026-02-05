using UnityEngine;

[CreateAssetMenu(fileName = "Armour", menuName = "Scriptable Objects/Armour")]

public class Armour: Equipment
{
    [SerializeField] protected int defenseValue;
    [SerializeField] protected string armourSlot;

    public int GetDefenseValue()
    {
        return defenseValue;
    }
    
    public string GetArmourSlot()
    {
        return armourSlot;
    }

    public void EquipArmour(string armourSlot)
    {
        //
    }
    
}
