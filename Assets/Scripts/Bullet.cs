using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;

    private int damage;
    private float liveTime;

    private void Start()
    {
        Initializate();
    }

    private void Update()
    {
        transform.localPosition += transform.forward * bulletSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        EntityController entity = collision.gameObject.GetComponent<EntityController>();
        if (entity)
        {
            Debug.Log(collision.gameObject.name);
            entity.Damage(damage);
        }
        if (this)
        {
            Destroy(this.gameObject);
        }
    }

    private void Initializate()
    {

    }
}
