using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventorySO", menuName = "ScriptableObject/InventorySO", order = 0)]
public class InventorySO : ScriptableObject
{
    public List<Item> listItens = new List<Item>();
}
