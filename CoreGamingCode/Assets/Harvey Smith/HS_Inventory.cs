using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class HS_Inventory : MonoBehaviour
{
    private int maxNumberSlots;
    private float maxTotalWeight;
    private float totalCurrentlWeight;
    private HS_ItemClass[] arrayOfItems;
    private List<HS_ItemClass> listOfItems;

    public HS_Inventory(int startNumberMaxSlots, float startMaxTotalWeight)
    {
        this.maxNumberSlots = startNumberMaxSlots;
        this.maxTotalWeight = startMaxTotalWeight;
        arrayOfItems = new HS_ItemClass[maxNumberSlots];
        listOfItems = new List<HS_ItemClass>();
        totalCurrentlWeight = 0;
    }

    internal bool AddRequest(HS_ItemClass item)
    {

        if ((totalCurrentlWeight + item.weight) > maxTotalWeight)
        {
            Debug.Log("Cannot as too heavy!!");
            return false;
        }
       
        ///list method
        if (listOfItems.Count < maxNumberSlots)
        {
            listOfItems.Add(item);
            totalCurrentlWeight += item.weight;
            return true;
        }
        else
        {
            return false;
        }

        /*
            ///array method
            int emptySlotIndex = findEmptySlot();
        if (emptySlotIndex != -1)
        {
            arrayOfItems[emptySlotIndex] = item;
            totalCurrentlWeight += item.weight;
            return true;
        }
        else { 
        return false;
        }
    }

    private int findEmptySlot()
    {
        for (int i = 0; i < arrayOfItems.Length; i++)
        {
            if (arrayOfItems[i] == null)
            {
                return i;
            }
        }
        return -1;
        */
    }

}
