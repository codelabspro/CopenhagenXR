using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float force = 500;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Jump")) 
       {
            body.AddForce(Vector2.up * force);
       }
    }

    private void onTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game Over");
    }
}
