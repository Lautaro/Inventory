using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A container where a stack of items is kept
/// </summary>
public class ItemContainer : MonoBehaviour
{


    public ItemBase item;

    public ItemBase Item
    {
        get
        {
            return Item;
        }

        set
        {
            print("New stack set");
            Item = value;
        }
    }



    /* public void MergeSlots(ItemContainer mergeStack)
     {
         if (mergeStack.Stack.name == mergeStack.Stack.name)
         {
             Stack.DoTransaction(mergeStack.Stack);
         }
         else
         {
             var tempStash = Stack;
             Stack = mergeStack.Stack;
             mergeStack.Stack = tempStash;
         }
     } */
}
