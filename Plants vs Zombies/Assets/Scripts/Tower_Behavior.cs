using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Behavior : MonoBehaviour
{
    public float colldown;
    private float colldownTimer;
    public GameObject projectile;
    public Transform shootingPoint;

    // Start is called before the first frame update
    void Start()
    {
        colldownTimer = colldown;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (colldownTimer > 0)
        {
            colldownTimer -= Time.deltaTime;        
        }
        else
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, Vector3.right, out hit, 165))
            {
                if (hit.transform.tag == "Enemy")
                {
                    colldownTimer = colldown;
                    Instantiate(projectile, shootingPoint.position, Quaternion.identity);
                }
            }
        }
    }
}
