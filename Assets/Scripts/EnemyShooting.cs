using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour
{
    public Transform target;
    public Transform enemy;
    //public bool IsAttacking = false;

    //new Rigidbody2D Bullet;

    public GameObject projectile;

    public float playerRange;

	// Use this for initialization
	void Start ()
    {
        if (target == null)
        {
            target = FindObjectOfType<Player>().transform;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
      
    }

   /* public void Attack()
    {
        Instantiate(projectile);

        projectile.transform.position = Vector3.Slerp(transform.position, target.position, Time.deltaTime);

        projectile.GetComponent<Rigidbody2D>().AddForce(projectile.transform.TransformDirection(new Vector2(-2000, 0)));


        r.transform.parent = null;
    }
    */
}
