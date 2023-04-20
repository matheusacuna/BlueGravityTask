using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPlayerManager : MonoBehaviour
{
    [SerializeField] private InventorySO inventoryPlayer;

    public EquipsPlayer equipsPlayer;
    public EquipsIlustrationPlayer equipsIlustrationPlayer;

    //Select and Choose an item to equip.
    public void UseItem()
    {
        switch (ShopManager.Instance.itemSelected.typeEquips)
        {
            case Equips.Hair:
                GetEquipsParts(equipsPlayer.hair, equipsIlustrationPlayer.hair);
                break;
            case Equips.Shirt:
                GetEquipsParts(equipsPlayer.Shirt, equipsIlustrationPlayer.Shirt);
                break;
            case Equips.Shoe:
                GetEquipsParts(equipsPlayer.shoes, equipsIlustrationPlayer.shoes);
                break;
        }
    }

    //Get Sprites Parts Equips from ShopManager Script to use in Function UseItem().
    private void GetEquipsParts(SpriteRenderer[] spriteReference, Image[] spriteImageReference)
    {
        for (int i = 0; i < spriteReference.Length; i++)
        {
            spriteReference[i].sprite = ShopManager.Instance.itemSelected.sprites[i];
            spriteImageReference[i].sprite = ShopManager.Instance.itemSelected.sprites[i];
        }
    }

    [System.Serializable]
    public class EquipsPlayer
    {
        public SpriteRenderer[] hair;
        public SpriteRenderer[] Shirt;
        public SpriteRenderer[] shoes;
    }

    [System.Serializable]
    public class EquipsIlustrationPlayer
    {
        public Image[] hair;
        public Image[] Shirt;
        public Image[] shoes;
    }
}

