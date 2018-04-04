using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  class ItemBase   {

    internal string Name;

    //int maxAmount = 100;
    //public int MaxAmount
    //{
    //    get
    //    {
    //        return maxAmount;
    //    }
    //}

    //int amount = 23;
    //public int Amount
    //{
    //    get
    //    {
    //        return Amount;
    //    }

    //    set
    //    {
    //        Amount = value;
    //    }
    //}

     string spriteDirectoryPath = "InventoryIcons/";
    internal string spriteName = "YellowBall";


    public string GetIconSpriteFilePath()
    {
        return spriteDirectoryPath + spriteName;
    }
}
