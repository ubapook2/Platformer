using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    const float DEAD_ZONE_HEIGHT = -5;
    public float maxSpeed = 1;
    public float jumpForce = 5;
    public Weapon currentWeapon;

    private Vector3 startPosition;
    private new Rigidbody2D rigidbody2D;

    private bool isDucking = false;
    private bool checkpointReached = false;
    


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

        if (Input.GetButtonDown("Fire1") && currentWeapon != null)
        {
            currentWeapon.Attack();
        }

        // Ducking mechanism
        if (Input.GetAxis("Vertical") < 0 && !isDucking)
        {
            var s = transform.localScale;
            s.y *= .7f;
            transform.localScale = s;
            isDucking = true;
        }
        if (Input.GetAxis("Vertical") >= 0 && isDucking)
        {
            var s = transform.localScale;
            s.y /= .7f;
            transform.localScale = s;
            isDucking = false;
        }

        // Flip mechanism for turning around
        if (rigidbody2D.velocity.x > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (rigidbody2D.velocity.x < 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
	}

    
    public void takeDamage()                   // part of taking 25 damage for collision with enemy obeject
    {
        FindObjectOfType<GM>().loseHealth();
    }

    public void CheckpointOne()   // Sets up the first Checkpoint
    {
        //checkpointReached = true;
        startPosition = new Vector2(FindObjectOfType<CheckpointOne>().Position.x, FindObjectOfType<CheckpointOne>().Position.y);
        //   FindObjectOfType<GM>().checkpoint();   // shows a sign that checkpoint has been reached
    }

    public void CheckpointTwo()   // Sets up the second Checkpoint
    {
        //checkpointReached = true;
        startPosition = new Vector2(FindObjectOfType<CheckpointTwo>().Position.x, FindObjectOfType<CheckpointTwo>().Position.y);
    }



    public void Die()
    {
        rigidbody2D.velocity = new Vector2();
        FindObjectOfType<GM>().LifeWasLost();
        transform.position = startPosition;
        FindObjectOfType<GM>().respawn();
    }




}
