using UnityEngine;

[CreateAssetMenu(fileName = "Treasure", menuName = "Scriptable Objects/Treasure")]

public class Treasure: Item
{
    [SerializeField] protected bool isStackable;
    [SerializeField] protected bool isConsumable;
    
    public bool GetStackability()
    {
        return isStackable;
    }

    public bool GetConsumability()
    {
        return isConsumable;
    }

    public void ChangeStats(string statName, int statValue)
    {
        
    }
    
}  
