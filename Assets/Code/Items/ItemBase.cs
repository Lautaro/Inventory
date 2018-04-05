using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemBase
{

    #region Statics
    static string spriteDirectoryPath = "InventoryIcons/";
    #endregion

    public ItemBase(int amount)
    {
        Amount = amount;
    }

    internal string spriteName = "YellowBall";

    Sprite icon;
    public Sprite Icon
    {
        get
        {
            if (icon != null)
            {
                return icon;
            }
            else
            {
                var path = spriteDirectoryPath + spriteName;
                icon = Resources.Load<Sprite>(spriteDirectoryPath + spriteName);

                return icon;
            }
        }
        set
        {
            icon = value;
        }
    }
    

    [SerializeField]
    public string Name;

    int maxAmount = 100;
    public int MaxAmount
    {
        get
        {
            return maxAmount;
        }
    }

    [SerializeField]
    int amount = 23;
    public int Amount
    {
        get
        {
            return amount;
        }

        set
        {
            amount = value;
        }
    }


}
