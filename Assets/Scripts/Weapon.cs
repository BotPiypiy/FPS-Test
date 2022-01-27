using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    [Header("Bullet prefab")]
    GameObject bullet;

    [Header("Weapon stats")]
    [SerializeField]
    private int damage;
    [SerializeField]
    private float fireDelay;
    [SerializeField]
    private float spray;
    [SerializeField]
    private float shootDistance;
    [SerializeField]
    private float reloadDelay;
    [SerializeField]
    private int ammo;

    public void Shoot()
    {

    }
}
