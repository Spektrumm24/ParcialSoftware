using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hearts = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Arrow"))
        {
            hearts -= 1;
            if (hearts <= 0)
            {
                Destroy(this.gameObject);
            }
            
        }
    }
}
