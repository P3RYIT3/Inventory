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

    public void AddItem(Item item)
    {
        if (inventory.Count < maxItemCount)
        {
            GameObject itemGameObject = Instantiate(itemPrefab, inventoryPanel.transform);
            
            ItemManager itemManager = itemGameObject.GetComponent<ItemManager>();
            itemManager.SetItem(item);
            
            inventory.Add(itemManager);
        }

        UpdateInventoryStatusText();
    }

    private void UpdateInventoryStatusText()
    {
        inventoryStatusText.text = $"{CalculateInventoryWeight()} / Max";
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
    
    //private int CalculateInventoryValue() {};
}
