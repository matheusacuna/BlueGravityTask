using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObject/Item", order = 0)]
public class Item : ScriptableObject
{
    public Sprite iconItem;
    public float buyPriceItem;
    public float resalePriceItem;

}
