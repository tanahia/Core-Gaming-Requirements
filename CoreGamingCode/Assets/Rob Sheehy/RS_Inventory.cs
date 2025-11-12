using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class RS_Inventory
{
    private int maxNumberSlots;
    private float maxTotalWeight;
    private float totalCurrentWeight;
    private ItemClass[] arrayOfItems;
    //private List<ItemClass> listOfItems;

    public RS_Inventory(int startMaxNumberSlots, float startMaxTotalWeight)
    {
        this.maxNumberSlots = startMaxNumberSlots;
        this.maxTotalWeight = startMaxTotalWeight;
        arrayOfItems = new ItemClass[maxNumberSlots];
       // listOfItems = new List<ItemClass>();
        totalCurrentWeight = 0;

    }

    internal bool AddRequest(ItemClass item)
    {
        if (totalCurrentWeight + item.weight > maxTotalWeight)
        {
            Debug.Log("Cannot as too heavy!!");
            return false;
        }
       

        /*
        if (listOfItems.Count < maxNumberSlots)
        {
            listOfItems.Add(item);
            totalCurrentWeight += item.weight;
            return true;
        }
        else
            { return false; }

        */

            // find empty slot
        int emptySlotIndex = findEmptySlot();
        if (emptySlotIndex != -1)
        {
            arrayOfItems[emptySlotIndex] = item;
            totalCurrentWeight += item.weight;
            return true;
        }
        else
            return false;
    }

    internal ItemClass RemoveRequest(int ind)
    {
        ItemClass item = arrayOfItems[ind];
        arrayOfItems[ind] = null;
        if (item != null)
            totalCurrentWeight -= item.weight;
        return item;
    }

    private int findEmptySlot()
    {
        for (int i = 0; i < arrayOfItems.Length; i++)
            if (arrayOfItems[i] == null)
                return i;
        return -1;
    }
}
