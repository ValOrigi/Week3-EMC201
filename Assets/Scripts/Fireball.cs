using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float projSpeed;
    public Rigidbody2D rigidBody2D;

    // Update is called once per frame
    void Update()
    {
        rigidBody2D.velocity = transform.right * projSpeed;
        Destroy(gameObject, 1f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "BreakableBlock") || (collision.gameObject.tag == "Floor"))
        {
            Destroy(gameObject);
        }
    }

}
