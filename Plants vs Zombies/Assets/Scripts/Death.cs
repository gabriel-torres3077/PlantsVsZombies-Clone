using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private Health objectHealth;
    public bool isTower;
    private Sun actualSuns;

    void Start()
    {
        //obter valor da vida do objeto
        objectHealth = gameObject.GetComponent<Health>();
        actualSuns = GameObject.Find("GameSystem").GetComponent<Sun>();
    }

    void Update()
    {
        if (objectHealth.health <= 0)
        { 
            if (isTower)
            {
                Destroy(gameObject);
            }
            else
            {
                actualSuns.sun += 50;
                Destroy(gameObject);
            }
        }
    }
}
