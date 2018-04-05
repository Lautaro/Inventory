using Assets.Code.Inventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    
  public class RedMineral : ItemBase
    {   
        public RedMineral(int amount): base(amount)
        {   
            Name = "Red Mineral";
            spriteName = "RedMineral";
        }        
    }
}
