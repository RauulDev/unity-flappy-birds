using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript2 : MonoBehaviour
{
    public Rigidbody2D MyRigidbody2D;
    public float flapStrength;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            MyRigidbody2D.velocity = Vector2.up * flapStrength;
    }
}
