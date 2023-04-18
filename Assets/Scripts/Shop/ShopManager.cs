using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] InventorySO invetoryPlayer;
    [SerializeField] InventorySO invetorShop;

    public Item itemSelected;

    public static ShopManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void GetItem(Item item)
    {
        itemSelected = item;
    }
}
