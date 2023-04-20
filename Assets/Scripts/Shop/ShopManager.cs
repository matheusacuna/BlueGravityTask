using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;

public class ShopManager : MonoBehaviour
{
    [Header("Item Selected")]
    public Item itemSelected;
    public GameObject itemSelectedObj;
    public bool isSelected;

    [Header("References Scripts")]
    [SerializeField] CoinManager coinManager;
    [SerializeField] InventorySO inventoryPlayer;
    public DisplayInventory displayInventory;

    [Header("Buttons Shop")]
    public GameObject buttonPurchase;
    public GameObject buttonSell;

    public Transform topParentTransform;

    public static ShopManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void GetItem(Item item, GameObject obj)
    {
        itemSelected = item;
        itemSelectedObj = obj;
     
        for (int i = 0; i < itemSelectedObj.transform.parent.childCount; i++)
        {
            itemSelectedObj.transform.parent.GetChild(i).GetChild(1).gameObject.SetActive(false);
        }
        itemSelectedObj.transform.GetChild(1).gameObject.SetActive(true);

        switch (itemSelectedObj.GetComponentInParent<DisplayInventory>().inventoryType)
        {
            case InventoryType.inventoryNPC:
                buttonPurchase.gameObject.SetActive(true);
                buttonSell.gameObject.SetActive(false);
                break;
            case InventoryType.inventoryPlayer:
                buttonPurchase.gameObject.SetActive(false);
                buttonSell.gameObject.SetActive(true);
                break;
        }
    }

    public void BuyItem()
    {
        if(coinManager.amountCoin >= itemSelected.buyPriceItem)
        {
            coinManager.DecrementCoin(itemSelected.buyPriceItem);
            inventoryPlayer.listItens.Add(itemSelected);
        }
    }

    public void SellItem()
    {
        coinManager.IncrementCoin(itemSelected.resalePriceItem);
        inventoryPlayer.listItens.Remove(itemSelected);
        Destroy(itemSelectedObj);
    }

}
