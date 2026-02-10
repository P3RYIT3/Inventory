using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    private List<ItemManager> inventory = new List<ItemManager>();
    [SerializeField] private int maxItemCount;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private TMP_Text inventoryStatusText;
    [SerializeField] private TMP_Text inventorySlotsText;
    [SerializeField] private TMP_Text inventoryValueText;

    private int usedItemSlots = 0;
    
    public void AddItem(Item item)
    {
        if (inventory.Count < maxItemCount)
        {
            GameObject itemGameObject = Instantiate(itemPrefab, inventoryPanel.transform);
            
            ItemManager itemManager = itemGameObject.GetComponent<ItemManager>();
            itemManager.SetItem(item);
            
            inventory.Add(itemManager);
            
            usedItemSlots++;
        }

        UpdateInventoryStatusText();
    }

    private void UpdateInventoryStatusText()
    {
        inventoryStatusText.text = $"{CalculateInventoryWeight()} Stone";
        inventorySlotsText.text = $"{usedItemSlots} / {maxItemCount}";
        inventoryValueText.text = $"{CalculateInventoryValue()} Gold";
    }

    private int CalculateInventoryWeight()
    {
        int weight = 0;
        foreach (ItemManager itemManager in inventory)
        {
            weight += itemManager.GetItem().GetWeight();
        }

        return weight;
    }
    
    private int CalculateInventoryValue()
    {
        int value = 0;
        foreach (ItemManager itemManager in inventory)
        {
            value += itemManager.GetItem().GetValue();
        }

        return value;
    }
    
    
    //private int CalculateInventoryValue() {};
}
