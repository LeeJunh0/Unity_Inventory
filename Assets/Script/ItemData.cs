using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObject/ItemData" ,order = int.MaxValue)]
public class ItemData : ScriptableObject
{  
    public enum Type { EQUIP, CONSUMP, NONE };
    [SerializeField]
    private Type itemtype = Type.NONE;
    public Type Itemtype { get { return itemtype; } }

    [SerializeField]
    private Sprite itemimage = null;
    public Sprite ItemImage { get { return itemimage; } }
    [SerializeField]
    private string itemname = "";
    public string ItemName { get { return itemname; } }
    [SerializeField]
    private string explanation = "";
    public string Explanation { get { return explanation; } }
    [SerializeField]
    private uint number = 0;
    public uint Number { get { return number; } }
}
