using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] InventorySO invetoryPlayer;
    public InventorySO inventoryShop;

    public Item itemSelected;
    public GameObject itemSelectedObj;

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
    }

    public void BuyItem()
    {
        if(coinManager.amountCoin >= itemSelected.buyPriceItem)
        {
            coinManager.DecrementCoin(itemSelected.buyPriceItem);
            invetoryPlayer.listItens.Add(itemSelected);
        }
    }

    public void SellItem()
    {
        coinManager.IncrementCoin(itemSelected.resalePriceItem);
        Destroy(itemSelectedObj);
    }

}
