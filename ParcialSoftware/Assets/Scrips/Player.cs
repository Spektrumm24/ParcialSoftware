using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int speed = 10;
    private Weapon _weapon;


    private void Update()
    {
        Attack();
        Move();
       
    }
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _weapon.Attack();
        }
    }
    public void SetWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }
    void Move()
    {
        float mov = Input.GetAxis("Horizontal");

        if (mov != 0)
        {
            transform.localScale = new Vector2(Mathf.Sign(mov), 1);
            transform.Translate(new Vector2(mov * speed * Time.deltaTime, 0));
        }
    }

    
}
