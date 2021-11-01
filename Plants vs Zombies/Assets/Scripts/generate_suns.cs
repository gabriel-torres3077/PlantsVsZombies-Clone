using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate_suns : MonoBehaviour
{
    public float cooldown;
    private float cooldownTimer;
    public int sunsGenerated;
    private Sun sun;
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("GameSystem").GetComponent<Sun>();
        cooldownTimer = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
        else
        {
            cooldownTimer = cooldown;
            sun.sun += sunsGenerated;
        }
    }
}
