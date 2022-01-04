using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();

    public void AddItem(ItemType Item, int Amount)
    {
        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++) 
        {
            if (Container[i].item == Item)// if item already exist in inventory add one more
            {
                Container[i].AddAmount(Amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem) // if item does not exist in inventory make a new inventoryslot
        {
            Container.Add(new InventorySlot(Item, Amount));
        }
    }
    public void RemoveItem(ItemType item, int Amount)
    {
        
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == item)
            {
                Container[i].RemoveAmount(Amount);
                break;
            }
        }
    }

    public bool Contains(ItemType itemType, out ItemType item)
    {
        item = ItemType.Default;
        for (int i = 0; i < Container.Count ; i++)
        {
            if (Container[i].item == itemType && Container[i].amount > 0)
            {
                item = Container[i].item;
                return true;
            }
        }
        return false;
    }
}
[System.Serializable]
public class InventorySlot
{
    public ItemType item;
    public int amount;

    public InventorySlot(ItemType Item, int Amount)
    {
        item = Item;
        amount = Amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
    public void RemoveAmount(int value)
    {
        amount -= value;
    }
}
