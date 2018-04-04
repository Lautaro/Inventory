using Assets.Code;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// En UI representation av en stack
/// </summary>
public class InventorySlot : ItemContainer {

     Image Icon;
     Text AmountText;
    public int Amount;

    [SerializeField]
    new public ItemBase Item;
    
    void Start () {
        var thing = new RedMineral();
        Item = thing;
        print(Item.Name);
        //Icon = transform.Find("Icon").GetComponent<Image>();
        //AmountText = transform.Find("Amount").GetComponentInChildren<Text>();
        //AmountText.text = Stack.Amount.ToString();

    }
	
}
