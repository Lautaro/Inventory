using Assets.Code.Inventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    class BlackLiquid : ItemBase
    {
        new string Name = "Black Liquid";
        string spriteName = ItemSpriteFileNames.BlackLiquid.ToString();
        int amount = 12;

    }
}
