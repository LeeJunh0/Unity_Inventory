using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreat : MonoBehaviour
{
    public List<GameObject> itemList;

    private void Start()
    {
        //itemList = new List<GameObject>();
    }

    public void Creat(int i)
    {
        Inventory.instance.InsertInven(itemList[i].GetComponent<Slot>().SlotItem);
    }
}
