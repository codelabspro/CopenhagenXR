using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoverControl : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D body;
    public float offScreenPosition = -15;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Store user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        body.MovePosition(this.transform.position + Vector3.left * Time.fixedDeltaTime * speed);

        if (this.transform.position.x < offScreenPosition) 
        {
            Destroy(this.gameObject);
        }
    }
}
