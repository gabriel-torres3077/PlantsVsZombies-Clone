using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies_Spawn : MonoBehaviour
{
    public int spawnNum;
    public GameObject[] enemiesArray;
    public float startDelay;
    public float colldown;
    private float colldownTimer;
    // Start is called before the first frame update
    void Start()
    {
        colldownTimer = colldown * startDelay;
    }

    // Update is called once per frame
    void Update()
    {
           if(colldownTimer > 0)
        {
            colldownTimer -= Time.deltaTime;
        }
        else
        {
            colldownTimer = colldown;
            Vector3 position = new Vector3(14, 0.03f, Random.Range(0, 4));
            int index = Random.Range(0, enemiesArray.Length);
            Instantiate(enemiesArray[index], position, Quaternion.identity);
            spawnNum++;

        }
    }
}
