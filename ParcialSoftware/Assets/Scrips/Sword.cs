using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, Weapon
{
    [SerializeField] private Transform _damageZoneCenter;
    [SerializeField] private float _damageZoneRadius;
    private readonly Collider2D[] _hitColliders = new Collider2D[10];

    public void Attack()
    {
        Debug.Log("Espadazo!!");
    }
}
