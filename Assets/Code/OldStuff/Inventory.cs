using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;



public class Inventory : MonoBehaviour {

    public InventorySlot HandSlot;

    private void Awake()
    {
        HandSlot = transform.Find("HandSlot").GetComponent<InventorySlot>();
    }

    private void Update()
    {
        if (HandSlot.Item == null && HandSlot.gameObject.activeSelf == true)
        {
            HandSlot.gameObject.SetActive(false);
        }
        else if (HandSlot.Item != null && HandSlot.gameObject.activeSelf == false)
        {
            HandSlot.gameObject.SetActive(true);
        }
    }
}
