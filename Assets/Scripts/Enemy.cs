using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    Vector3 direction = Vector3.left;
    // Update is called once per frame
    void Update()
    {
        /*
        transform.position += direction * Time.deltaTime;
        if (transform.position.x <= -1)
        {
            direction = new Vector3(1, .3f);
        }
        if (transform.position.x >= 6)
        {
            direction = new Vector3(-1, -.3f);
        }
        */
        transform.position = Vector3.Slerp(transform.position, FindObjectOfType<Player>().transform.position, Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if(player != null)
        {
            player.Die();
        }
    }
}
