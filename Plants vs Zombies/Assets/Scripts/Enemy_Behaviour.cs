using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behaviour : MonoBehaviour
{
    public float MovementSpeed;
    public int zombieValue;
    public int damage;
    public float attackSpeed;
    private float cd;

    // Update is called once per frame
    void Start()
    {
        cd = attackSpeed;
    }
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.left, out hit, 2))
        {
            if (hit.transform.tag == "Towers")
            {
                Health towerHealth = hit.transform.gameObject.GetComponent<Health>();
                if (cd > 0)
                {
                    cd -= Time.deltaTime;
                }
                else
                {
                    Debug.Log(towerHealth.health);
                    towerHealth.health -= damage;
                    cd = attackSpeed;
                }
            }
            else if (hit.transform.tag == "house")
            {
                //game over

            }
            else
            {
                transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
            }
        } 
        
 
       
    }
}
