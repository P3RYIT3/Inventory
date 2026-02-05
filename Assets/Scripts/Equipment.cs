using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Scriptable Objects/Equipment")]


public class Equipment: Item
{
    [SerializeField] protected string[] enchantment;
    [SerializeField] protected int condition;
    
    public string GetEnchantment()
    {
        return enchantment.ToString();
    }
    
    public int GetCondition()
    {
        return condition;
    }

    public void EnchantEquipment(string newEnchantment)
    {
        
    }

    public void DisenchantEquipment(string removedEnchantment)
    {
        
    }

    public void RepairEquipment(int repairValue)
    {
        condition += repairValue;
    }

}
