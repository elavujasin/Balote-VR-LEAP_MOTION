using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnitude : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    { 
        
    }
    // Update is called once per frame
    void Update()
    {
        if (ball.GetComponent<Rigidbody>().velocity.magnitude < 0.1)
        {ball.GetComponent<Rigidbody>().velocity = ball.GetComponent<Rigidbody>().velocity.normalized * 0; }
    }
}
