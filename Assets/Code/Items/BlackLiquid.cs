using Assets.Code.Inventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    public class BlackLiquid : ItemBase
    {
        public BlackLiquid(int amount) : base(amount)
        {
            Name = "Black Liquid";
            spriteName = "BlackLiquid";
        }
    }
}
