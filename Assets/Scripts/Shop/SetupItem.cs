using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class SetupItem : MonoBehaviour
{
    public Item item;
    public Image iconItem;
    // Start is called before the first frame update
    void Start()
    {
        iconItem.sprite = item.iconItem;
    }
}
