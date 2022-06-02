using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testplatform : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       rb.position += Vector3.back * (Time.deltaTime * speed); 
    }
}
