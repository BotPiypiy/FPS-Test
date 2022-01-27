using UnityEngine;

public abstract class EntityController : MonoBehaviour
{
    protected int hp;
    [SerializeField]
    protected float moveSpeed;

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
