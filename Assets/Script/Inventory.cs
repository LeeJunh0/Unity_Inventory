using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance = null;
    public Camera MainCamera;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }

        instance = this;
        DontDestroyOnLoad(this);
    }

    public GameObject InventoryUI;
    public List<ItemData> SlotList;
    public GameObject ExplanationUI;
    public GameObject Content;
    public GameObject SlotPrefab;
    bool SetActiveInven = false;
    public GameObject curItem = null;

    private void Start()
    {
        SlotList = new List<ItemData>();
        InventoryUI.SetActive(SetActiveInven);
        ExplanationUI.transform.SetAsLastSibling();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            SetActiveInven = !SetActiveInven;
            InventoryUI.SetActive(SetActiveInven);
        }
    }
    
    public void InsertInven(ItemData Item)
    {
        GameObject NewItem = Instantiate(SlotPrefab);
        Slot NewData = NewItem.GetComponent<Slot>();
        NewData.SlotItem = Item;

        SlotList.Add(NewData.SlotItem);
        NewItem.transform.SetParent(Content.transform);
    }
    public void ExplanUIInit(ItemData data)
    {    
        Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
        
        ExplanationUI.transform.GetChild(0).GetComponent<Text>().text = data.Explanation;
        ExplanationUI.transform.GetChild(1).GetComponent<Image>().sprite = data.ItemImage;
        ExplanationUI.transform.GetChild(2).GetComponent<Text>().text = string.Format("°³¼ö : {0}", data.Number);

        RectTransform rect = ExplanationUI.GetComponent<RectTransform>();
        rect.position = Input.mousePosition;
    }

    public void DeleteItem()
    {
        if (curItem == null) return;

        Destroy(curItem);
        curItem = null;
    }
}
