using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class bulletMove : MonoBehaviour
{
    [DllImport("dll")]
    private static extern float NewSP();

    private Rigidbody rb;
    public float speed;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        damage = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0.01f * speed, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
