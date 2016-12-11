using UnityEngine;
using System.Collections;

public class EnemyTurning : MonoBehaviour {

    private Vector3 startPosition;
    private new Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (rigidbody2D.velocity.x > 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        else if (rigidbody2D.velocity.x < 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

    }
}
