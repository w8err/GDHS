using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            GameManager.Instance.AddScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
