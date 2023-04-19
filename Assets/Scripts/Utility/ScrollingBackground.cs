using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private RawImage rawImg;
    [SerializeField] private float x, y;

    private void Update()
    {
        rawImg.uvRect = new Rect(rawImg.uvRect.position + new Vector2(x, y) * Time.deltaTime, rawImg.uvRect.size);
    }
}
