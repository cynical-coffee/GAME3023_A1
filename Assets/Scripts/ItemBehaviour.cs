using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "InventorySystem/Item")]
public class ItemBehaviour : ScriptableObject
{
    [Header("Item Attributes")]
    public string sName = "Item";
    public string sDescription = "Item Description";
    public int iMaxStackNum = 10;
    public string sCategory = "";
    public bool bIsConsumable = true;
    public Sprite mIcon;

    public bool UseItem()
    {
        Debug.Log("Used " + sName + ".");
        return bIsConsumable;
    }
}
