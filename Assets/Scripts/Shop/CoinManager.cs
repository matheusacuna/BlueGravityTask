using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public float amountCoin;
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
