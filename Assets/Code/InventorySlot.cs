﻿using Assets.Code;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// En UI representation av en stack
/// </summary>
public class InventorySlot : ItemContainer
{

    Image Icon;
    Text AmountText;

    private void Awake()
    {
        Icon = transform.Find("Icon").GetComponent<Image>();
        AmountText = transform.Find("Amount/Text").GetComponent<Text>();
        
    }

    private void Update()
    {
        if (Item != null && AmountText.text != Item.Amount.ToString())
        {
            AmountText.text = Item.Amount.ToString();
        }
    }

    public override void OnItemSet()
    {
        Icon.sprite = Item.Icon;
    }

}
