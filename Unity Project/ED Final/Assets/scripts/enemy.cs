using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health;
    public float damage;
    public float speed;

    public bool direction;

    public float time;
    public float period;
    public Vector3 spawnPoint;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public virtual string getType()
    {
        return "default";
    }

    
}
