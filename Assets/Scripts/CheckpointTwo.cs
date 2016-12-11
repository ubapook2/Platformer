using UnityEngine;
using System.Collections;

public class CheckpointTwo : MonoBehaviour {

    public Vector3 Position;

    // Use this for initialization
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            FindObjectOfType<Player>().CheckpointTwo();
        }
    }
}
