using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]

public class Item: ScriptableObject
{
    [SerializeField] protected string name;
    [SerializeField] protected string description;
    [SerializeField] protected string material;
    [SerializeField] protected int weight;
    [SerializeField] protected string type;
    [SerializeField] protected int value;
    [SerializeField] protected string rarity;
    [SerializeField] protected int levelCap;
    [SerializeField] protected bool isCraftable;
    [SerializeField] protected bool isDeconstructable;
    [SerializeField] protected Sprite sprite;
    
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

    public int GetLevelCap()
    {
        return levelCap;
    }
    
    public Sprite GetSprite()
    {
        return sprite;
    }

    public string DeconstructItem()
    {
        if (isDeconstructable)
        {
            return material;
        } 
        else
        {
            return "";
        }
    }

    public bool GetCraftability()
    {
        return isCraftable;
    }

    public int SellItem()
    {
        return value;
    } 
}
