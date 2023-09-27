using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollison : MonoBehaviour
{

    public int coinVal = 0;
    // Start is called before the first frame update
    void Start()
    {
        // if there is already an extisitng object of this type in the scene
        if (FindObjectsOfType<ObjectCollison>().Length > 1)
        {
            // then destory this current one so there is not 2
            Destroy(gameObject);
        }
        else
        {
            // otherwise if there is NOT, then carry it onto the next scene
            DontDestroyOnLoad(gameObject);
        }

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
