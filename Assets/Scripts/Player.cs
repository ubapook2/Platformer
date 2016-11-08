using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    const float DEAD_ZONE_HEIGHT = -2;
    private Vector3 startPosition;
    public float maxSpeed = 1;
    public float jumpForce = 5;
    private new Rigidbody2D rigidbody2D;


    // Use this for initialization
    void Start ()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(transform.position.y < DEAD_ZONE_HEIGHT)
        {
            Die();
        }

        var x_force = Input.GetAxis("Horizontal");
        rigidbody2D.velocity += Vector2.right * x_force;
        rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxSpeed);

        if (Input.GetButtonDown("Jump") && rigidbody2D.velocity.y == 0)
        {
            rigidbody2D.velocity += Vector2.up * jumpForce;
        }

        if (rigidbody2D.velocity.x > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (rigidbody2D.velocity.x < 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
	}


    public void Die()
    {
        transform.position = startPosition;
        rigidbody2D.velocity = new Vector2();
        FindObjectOfType<GM>().LifeWasLost();
    }


}
