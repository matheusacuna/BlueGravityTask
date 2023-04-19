using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayerManager : MonoBehaviour
{
    [SerializeField] private InventorySO inventoryPlayer;

    public EquipsPlayer equipsPlayer;

    public void UseItem()
    {
        switch (ShopManager.Instance.itemSelected.typeEquips)
        {
            case Equips.Hair:
                GetEquipsParts(equipsPlayer.hair);
                break;
            case Equips.Shirt:
                GetEquipsParts(equipsPlayer.Shirt);
                break;
            case Equips.Shoe:
                GetEquipsParts(equipsPlayer.shoes);
                break;
        }
    }

    private void GetEquipsParts(SpriteRenderer[] spriteReference)
    {
        for (int i = 0; i < spriteReference.Length; i++)
        {
            spriteReference[i].sprite = ShopManager.Instance.itemSelected.sprites[i];
        }
    }

    [System.Serializable]
    public class EquipsPlayer
    {
        public SpriteRenderer[] hair;
        public SpriteRenderer[] Shirt;
        public SpriteRenderer[] shoes;
    }
}

