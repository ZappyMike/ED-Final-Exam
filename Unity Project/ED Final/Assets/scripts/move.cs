using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    private float dirX, dirY;
    public float health;

    public GameObject bullet;
    private Vector3 spawnPoint;

    void Start()
    {
        speed = 3f;
        rb = GetComponent<Rigidbody>();
        health = 3;
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("ded");
        }

        dirX = Input.GetAxis("Horizontal") * speed;
        dirY = Input.GetAxis("Vertical") * speed;

        spawnPoint = transform.position + new Vector3(0f, -2f, 0f);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, spawnPoint, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            health -= 1;
        }
    }
}
