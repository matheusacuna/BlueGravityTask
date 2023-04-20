using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinManager : MonoBehaviour
{
    public float amountCoin;
    public TextMeshProUGUI amountCoinTextUI;


    private void Update()
    {
        amountCoinTextUI.text = $"£{amountCoin}";
    }
    // Start is called before the first frame update
    public void IncrementCoin(float value)
    {
        amountCoin += value;
    }

    public void DecrementCoin(float value)
    {
        amountCoin -= value;
    }
}
