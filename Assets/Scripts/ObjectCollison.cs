using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollison : MonoBehaviour
{

    public int coinVal = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "coin")
        {
            coinVal += 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "trash")
        {
            coinVal -= 1;
            Destroy(collision.gameObject);
        }
    }
}
