using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : EntityController
{
    private Rigidbody rigidbody;

    void Awake()
    {
        Initializate();
    }

    void Update()
    {
        Move();
        Shoot();
    }

    private void Initializate()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    protected override void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        rigidbody.MovePosition(rigidbody.position + transform.right * moveX + transform.forward * moveZ);
    }

    protected override void Shoot()
    {

    }

    protected override void Dead()
    {
        
    }

}
