using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHead : MonoBehaviour
{
    public float power = 3;
    Rigidbody2D jaw;

    Vector3 diagonalLeft = new Vector3(1, 1, 0);
    Vector3 diagonalRight = new Vector3(-1, 1, 0);



    // Start is called before the first frame update
    void Start()
    {
        jaw = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKeyDown(KeyCode.D))
        {
            jaw.AddForce(diagonalLeft * power, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            jaw.AddForce(diagonalRight * power, ForceMode2D.Impulse);
        }
    }
}
