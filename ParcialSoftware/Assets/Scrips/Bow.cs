using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour, Weapon
{
    [SerializeField] private GameObject _arrowPrefab;
    [SerializeField] private Transform _spawnReference;

    public void Attack()
    {
        //var arrow = Instantiate(_arrowPrefab, _spawnReference.position, _spawnReference.rotation);
        GameObject arrow = ObjectPool.instance.GetPooledObjetc();
        if(arrow != null)
        {
            arrow.transform.position = _spawnReference.position;
            arrow.SetActive(true);
        }
    }
}
