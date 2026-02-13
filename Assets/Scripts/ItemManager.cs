using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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

    public interface IPointerEnterHandler : IEventSystemHandler
    {
        void OnPointerEnter(PointerEventData eventData);
    }

    public interface IPointerExitHandler : IEventSystemHandler
    {
        void OnPointerExit(PointerEventData eventData);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            inventoryManager.ShowItemDescription(item.GetDescription());
            inventoryManager.ShowItemName(item.GetName());
            inventoryManager.ShowItemPic(item.GetSprite());
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inventoryManager.ShowItemDescription("");
        inventoryManager.ShowItemName("");
        inventoryManager.ShowItemPic(null);
    }

    public void OnDestroy()
    {
        inventoryManager.ShowItemDescription("");
        inventoryManager.ShowItemName("");
        inventoryManager.ShowItemPic(null);
    }
    
}
