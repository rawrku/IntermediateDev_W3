using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndText : MonoBehaviour
{
    public TMP_Text endText;

    private ObjectCollison CoinScript;

    // Start is called before the first frame update
    void Start()
    {
        CoinScript = FindObjectOfType<ObjectCollison>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CoinScript.coinVal >= 1)
        {
            endText.text = "You Win!\nYou ate: " + CoinScript.coinVal.ToString() + " coins!";
        }

        if (CoinScript.coinVal <= 0)
        {
            endText.text = "You Loose!\nYou failed to eat enough coins...";
        }

    }
}
