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
        
    void Start () {
        var thing = new RedMineral();
        Item = thing;
        print(Item.Name);
        Icon = GameObject.Find("Icon").GetComponent<Image>();

        var path = thing.GetIconSpriteFilePath();
        print(path);
        var sprite = Resources.Load<Sprite>(path);
        print(sprite.name);
        Icon.sprite = sprite;

        //AmountText = transform.Find("Amount").GetComponentInChildren<Text>();
        //AmountText.text = Stack.Amount.ToString();

    }
	
}
