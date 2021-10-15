using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotBehaviour : MonoBehaviour
{
    public ItemBehaviour mItemInSlot = null;
    [SerializeField] 
    private Image mItemIcon;
    [SerializeField] 
    private TextMeshProUGUI mItemCountText;

    public int ItemCount { get; set; } = 0;

    void Start()
    {
        RefreshItemInformation();
    }

    void RefreshItemInformation()
    {
        if (ItemCount < 1)
        {
            mItemInSlot = null;
        }

        if (mItemInSlot != null)
        {
            mItemCountText.text = ItemCount.ToString();
            mItemIcon.sprite = mItemInSlot.mIcon;
            mItemIcon.gameObject.SetActive(true);
        }
        else
        {
            mItemIcon.gameObject.SetActive(false);
        }
    }

}
