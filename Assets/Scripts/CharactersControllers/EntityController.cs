using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class EntityController : MonoBehaviour
{
    [SerializeField]
    protected int hp;
    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected Transform firePoint;      //position of creating bullets

    protected Rigidbody rigidbody;

    protected abstract void Move();
    protected abstract void Shoot();
    protected abstract void Dead();

    public void Damage(int value)
    {
        hp -= value;
        if(hp<=0)
        {
            Dead();
        }
    }
}
