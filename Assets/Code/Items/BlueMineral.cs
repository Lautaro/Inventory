using Assets.Code.Inventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    public class BlueMineral : ItemBase
    {
        public BlueMineral(int amount): base(amount)
        {
            Name = "Blue Mineral";
            spriteName = "BlueMineral";
        }
    }
}
