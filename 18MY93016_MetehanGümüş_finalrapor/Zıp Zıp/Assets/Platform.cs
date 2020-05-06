using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float ZıplamaHızı = 10f;
    void OnCollisionEnter2D(Collision2D collision) // Çarpışmayı algılama Kodu
    {
        if (collision.relativeVelocity.y <= 0f)
        {

        }
      Rigidbody2D rb =  collision.collider.GetComponent<Rigidbody2D>(); // Rigidbody2D scriptini tanımladık
        if (rb != null)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = ZıplamaHızı;
            rb.velocity = velocity;
        }
    }
}
