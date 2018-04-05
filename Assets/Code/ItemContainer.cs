using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A container where a stack of items is kept
/// </summary>
[Serializable]
public class ItemContainer : MonoBehaviour
{

    [SerializeField]
     ItemBase item ;

    public ItemBase Item
    {
        get
        {
            if (item == null)
            {
                return null;
            }
            else
            {

            }
            return item;
        }

        set
        {
            print("New stack set");
            item = value;
            OnItemSet();
        }
    }

   public virtual void OnItemSet()
    {

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
