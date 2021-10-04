using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Arrow : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Awake()
    {
        //gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * _speed;
        //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(_speed, 2), ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy") || collision.collider.CompareTag("Ground"))
        {
            //Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
        
    }
}
