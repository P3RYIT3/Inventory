using UnityEngine;

[CreateAssetMenu(fileName = "Material", menuName = "Scriptable Objects/Material")]

public class Material: Item
{
    [SerializeField] protected bool isCraftingIngredient;

    public bool GetCraftingUsage()
    {
        return isCraftingIngredient;
    }
    
    public void CraftItem()
    {
        if (isCraftingIngredient)
        {
            Debug.Log("Crafted something....");
        }
    }
    
}
