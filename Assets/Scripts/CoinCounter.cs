using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{

    public static CoinCounter instance;
    
    public TMP_Text coinText;
    public int currentCoins;

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
     coinText.text = "COINS: " + currentCoins.ToString();

    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    public int GetCurrentCoins()
    {
        return currentCoins;
    }
}
