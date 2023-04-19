using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] InventorySO invetoryPlayer;
    [SerializeField] InventorySO invetorShop;

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
    }

    public void BuyItem()
    {
        if(coinManager.amountCoin >= itemSelected.buyPriceItem)
        {
            coinManager.DecrementCoin(itemSelected.buyPriceItem);
            invetoryPlayer.listItens.Add(itemSelected);
        }
    }
}
