using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinsControler : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private static bool playerSubscribed = false;
    
    void Start()
    {
        if (!playerSubscribed)
        {
            Player.CoinsChanged += UpdateCoinDisplay;
            playerSubscribed = true;
        }

        if (coinText == null)
        {
            Debug.LogError("O componente de texto não está atribuindo em CoinController");
            return;
        }

        UpdateCoinDisplay(Player.coins);

    }

    // Update is called once per frame
    void UpdateCoinDisplay(int coins)
    {
        coinText.text = "X:" + coins.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.coins++;
            Debug.Log("Numero de moedas:" + Player.coins);
            Player.CoinsChanged?.Invoke(Player.coins);
        }
    }
}
