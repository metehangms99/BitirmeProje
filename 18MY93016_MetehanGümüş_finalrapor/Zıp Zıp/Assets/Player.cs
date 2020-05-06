using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour

    

{
    
    private float topScore = 0.0f; // score
    public UnityEngine.UI.Text scoreText; // score
    public float movementSpeed = 10f;


    
    
    void Olme()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    
    private void OnTriggerEnter(Collider nesne)

    {
        if (nesne.gameObject.tag == "Havuc")
        {
            Destroy(nesne.gameObject);
        }
    }
     private static int GetLoadlevel()
    {
        return Application.loadedLevel;

    }

    Rigidbody2D rb;

    float movement = 0f;
    
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed; // hareket modu burada  hatırla
        if(rb.velocity.y > 0 && transform.position.y > topScore) // score
            
        {
            topScore = transform.position.y; // score
        }
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();  // score
    }
     void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

        if (transform.position.y < -7f)
        {
            Olme();
        }

    }
}
