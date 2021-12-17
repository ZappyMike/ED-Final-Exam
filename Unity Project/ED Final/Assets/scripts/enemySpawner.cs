using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject weakEnemy;
    public GameObject strongEnemy;

    public float time;
    public float period;

    enemy Enemy;
    bool end = true;

    // Start is called before the first frame update
    void Start()
    {
        period = 5f;
        Enemy = Factory.EnemyType("Weak");

        if (Enemy.getType() == "weak")
        {
            Instantiate(weakEnemy, new Vector3(0.04f, 2.88f, 0f), Quaternion.identity);
        }
        //Debug.Log(Enemy.getType());

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= period && end)
        {
            time -= period;

            Enemy = Factory.EnemyType("Strong");

            if (Enemy.getType() == "strong")
            {
                Instantiate(strongEnemy, new Vector3(0.04f, 3.88f, 0f), Quaternion.identity);
            }

            end = false;
        }



 
    }
}
