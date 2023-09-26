using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{

    public TMP_Text coinText;

    public ObjectCollison coinScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        coinText.text = coinScript.coinVal.ToString();


    }
}
