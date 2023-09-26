using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{

    public static CoinCounter instance;

    public TMP_Text coinText;

    public GameObject head;
    private ObjectCollison coinScript;
    // Start is called before the first frame update
    void Start()
    {
        coinScript = head.GetComponent<ObjectCollison>();
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
