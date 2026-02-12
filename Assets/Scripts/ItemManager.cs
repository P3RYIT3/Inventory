using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    private Item item;
    private InventoryManager inventoryManager;

    public void SetInventoryManager(InventoryManager inventoryManager)
    {
        this.inventoryManager = inventoryManager;
    }

    public void Consume()
    {
        inventoryManager.ConsumeItem(this);
    }
    
    public void SetItem(Item item)
    {
        this.item = item;

        if (item.GetSprite() != null)
        {
            GetComponent<Button>().image.sprite = item.GetSprite();
        }
    }

    public Item GetItem()
    {
        return item;
    }
}
