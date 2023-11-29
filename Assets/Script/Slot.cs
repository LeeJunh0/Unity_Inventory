using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public ItemData SlotItem = null;
    Image SlotImage;
    Button Slotbutton;

    private void Start()
    {
        Slotbutton = GetComponent<Button>();
        SlotImage = transform.GetChild(0).GetComponent<Image>();
        SlotImage.sprite = SlotItem.ItemImage;
        Slotbutton.onClick.AddListener(() => SlotGet());
    }

    
    
    private void SlotGet()
    {
        Inventory.instance.curItem = this.gameObject;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Inventory.instance.ExplanationUI.SetActive(true);
        Inventory.instance.ExplanUIInit(SlotItem);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Inventory.instance.ExplanationUI.SetActive(false);
    }
}
