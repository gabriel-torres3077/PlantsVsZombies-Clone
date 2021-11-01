using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Behavior : MonoBehaviour
{
    public float speed;
    public int damage;
    public Vector3 initialPosition;
    private void Start()
    {
        initialPosition = transform.position;
    }
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if ((Vector3.Distance(transform.position, initialPosition)) > 30)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Health>().health -= damage;
            //teste1
            Destroy(gameObject);
        }
    }
}
