using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            FindObjectOfType<GM>().ammoPickedUp();
            Destroy(this.gameObject);
        }
    }
}
