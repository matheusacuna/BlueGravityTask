using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Equips {Hair, Shirt, Shoe }

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObject/Item", order = 0)]
public class Item : ScriptableObject
{
    public Equips typeEquips;
    public Sprite iconItem;
    public float buyPriceItem;
    public float resalePriceItem;
    public List<Sprite> sprites = new List<Sprite>();


}
