using UnityEngine;
using UnityEngine.UI;

public class InventoryAdder : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Item item;
    [SerializeField] private InventoryManager inventoryManager;

    private void Awake()
    {
        if (item != null && item.GetSprite() != null)
        {
            image.sprite = item.GetSprite();
        }
    }

    public void AddItemToInventory()
    {
        inventoryManager.AddItem(item);
    }
    
}
