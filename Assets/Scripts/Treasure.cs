using UnityEngine;

[CreateAssetMenu(fileName = "Treasure", menuName = "Scriptable Objects/Treasure")]

public class Treasure: ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] private string material;
    [SerializeField] private int weight;
    [SerializeField] private string type;
    [SerializeField] private int value;
    [SerializeField] private string rarity;
    [SerializeField] private bool isStackable;
    [SerializeField] private bool isConsumable;
    [SerializeField] private Sprite sprite;

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetMaterial()
    {
        return material;
    }

    public int GetWeight()
    {
        return weight;
    }

    public string GetType()
    {
        return type;
    }

    public int GetValue()
    {
        return value;
    }

    public string GetRarity()
    {
        return rarity;
    }

    public bool IsStackable()
    {
        return isStackable;
    }

    public bool IsConsumable()
    {
        return isConsumable;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public void ChangeStats(string statName, int statValue)
    {
        
    }

    public int SellItem(string itemName)
    {
        return 0;
    }
}  
