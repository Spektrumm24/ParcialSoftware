using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Player _PlayerPrefab;
    [SerializeField] private Sword _swordPrefab;
    [SerializeField] private Bow _bowPrefab;

    [SerializeField] private bool _useSword;
    private Player player;
    private Weapon weapon;

    private void Awake()
    {
        player = Instantiate(_PlayerPrefab);
        weapon = GetWeapon(player.transform);
        player.SetWeapon(weapon);    
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _useSword = !_useSword;
            ChangeWeapoon();
        }
    }
    private void ChangeWeapoon()
    {
        Destroy(player.transform.GetChild(0).gameObject);
        weapon = GetWeapon(player.transform);
        player.SetWeapon(weapon);
    }

    private Weapon GetWeapon(Transform parent)
    {
        if (_useSword)
        {
            return Instantiate(_swordPrefab, parent);
        }

        return Instantiate(_bowPrefab, parent);
    }
}
