using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StrongEnemy : enemy
{
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        damage = 3;
        speed = 3;
        direction = true;
        time = 0f;
        period = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        spawnPoint = transform.position + new Vector3(0f, -1f, 0f);

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("win");
        }

        if (direction)
            transform.position += new Vector3(0.001f * speed, 0f, 0f);
        else
            transform.position += new Vector3(-(0.001f * speed), 0f, 0f);

        if (time >= period)
        {
            time -= period;

            Instantiate(bullet, spawnPoint, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health -= 1;
        }

        if (collision.gameObject.tag == "wall")
        {
            if (direction)
                direction = false;
            else
                direction = true;
        }
    }

    public override string getType()
    {
        return "strong";
    }


}
