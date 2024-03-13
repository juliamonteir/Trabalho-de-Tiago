using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public static int coins = 0;
    public static Action<int> CoinsChanged; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            coins++;
            Debug.Log("Numero de moedas" + coins);
            CoinsChanged?.Invoke(coins);
        }
    }
}
