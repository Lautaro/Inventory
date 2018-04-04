using Assets.Code.Inventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    class BlueMineral : ItemBase
    {
        new string Name = "Blue Mineral";
        string spriteName = ItemSpriteFileNames.Slime.ToString();
        int amount = 70;
    }
}
