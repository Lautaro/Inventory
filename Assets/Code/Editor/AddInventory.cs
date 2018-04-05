using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;
using Assets.Code;

public class AddInventory : EditorWindow
{

    public Inventory myInventory;
    List<InventorySlot> slots;
    ItemTypes addType = ItemTypes.BlackLiquid;
    int amount;

    [MenuItem("Inventory/Add items")]
    public static void ShowWindow()
    {

        GetWindow<AddInventory>("Add items");

    }

    private void Awake()
    {

    }

    void OnGUI()
    {

        GUILayout.Label("Add items to  inventory", EditorStyles.boldLabel);

        myInventory = (Inventory)EditorGUILayout.ObjectField("Target inventory", myInventory, typeof(Inventory), true);

        if (myInventory != null)
        {
            slots = GetAllInventorySlots();
            foreach (var slot in slots)
            {
             
                DrawSlot(slot);
            }
        }
    }

    private void DrawSlot(InventorySlot slot)
    {
        GUILayout.Label(slot.name, EditorStyles.boldLabel);

        GUILayout.BeginVertical(EditorStyles.helpBox);
        GUILayout.BeginHorizontal(GUILayout.MaxWidth(500));

        if (slot.Item != null)
        {
            
            DrawSlotWithItem(slot);

        }
        else
        {
            DrawEmptyItem(slot);

        }

        GUILayout.EndHorizontal();
        GUILayout.EndVertical();

        GUILayout.Space(20);
    }

    private void DrawEmptyItem(InventorySlot slot)
    {
       
        GUILayout.BeginVertical();
        EditorGUILayout.LabelField("Empty. Create Item:", GUILayout.MaxWidth(130));
        
        // chose item
        var itemType = DrawTypeListPopUp();

        GUILayout.EndVertical();

        // chose amount
        GUILayout.BeginVertical();
        GUILayout.Label("Amount: ", GUILayout.MaxWidth(50));
        amount = EditorGUILayout.IntField("",amount, GUILayout.MaxWidth(50));
        GUILayout.EndVertical();

        // add item
        if (GUILayout.Button("Add Item", GUILayout.MaxWidth(80), GUILayout.Height(30)))
        {
            CreateItemInSlot(slot);

        }
    }

    private void CreateItemInSlot(InventorySlot slot)
    {
        ItemBase newItems= null;

        switch (addType)
        {
            case ItemTypes.RedMineral:
                newItems = new RedMineral(amount);
                break;

            case ItemTypes.BlackLiquid:
                newItems = new BlackLiquid(amount);
                break;

            case ItemTypes.BlueMineral:
                newItems = new BlueMineral(amount);
                break;

            default:
                break;
        }

        slot.Item = newItems;
    }

    private ItemTypes DrawTypeListPopUp()
    {
        
        addType = (ItemTypes)EditorGUILayout.EnumPopup("", addType, GUILayout.MaxWidth(150));
        return addType;
    }

    private void DrawSlotWithItem(InventorySlot slot)
    {
        // display icon
        GUILayout.Label(slot.Item.Icon.texture);

        // display amount
        GUILayout.BeginVertical();

        GUILayout.Label(slot.Item.Name);

        // Doesnt work 
        //var serializedObj = new UnityEditor.SerializedObject(slot.Item.Amount);

        var amount = slot.Item.Amount.ToString();
        var max = slot.Item.MaxAmount;
      //  EditorGUILayout.PropertyField(slot.Item.Amount); // cant convert from int to serialized object

        GUILayout.EndVertical();
    }

    private List<InventorySlot> GetAllInventorySlots()
    {
        slots = myInventory.GetComponentsInChildren<InventorySlot>().ToList();
        return slots;
    }

    enum ItemTypes
    {
        RedMineral,
        BlackLiquid,
        BlueMineral
        
    }
}
