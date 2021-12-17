using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public static enemy EnemyType(string type)
    {
        switch (type)
        {
            case "Weak" :
                return new weakEnemy();
            case "Strong" :
                return new StrongEnemy();
            default:
                return null; 
        }
    }
        

}
