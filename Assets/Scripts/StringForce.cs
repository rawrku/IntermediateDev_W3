using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringForce : MonoBehaviour
{

    private float timer;

    private float maxTime = 4f;
    private float minTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -700));
            timer = Random.Range(minTime, maxTime);
            Debug.Log("FORCE");

        } else
        {
            timer -= Time.deltaTime;
        }
    }
}
