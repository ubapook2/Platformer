using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TreasureChest : MonoBehaviour {

    public GameObject chestClosed;
    public GameObject chestOpen;
    public GameObject heart;

	// Use this for initialization
	void Start () {
        chestClosed.SetActive(true);
        chestOpen.SetActive(false);
        heart.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            chestClosed.SetActive(false);
            chestOpen.SetActive(true);
            heart.SetActive(true);
            //FindObjectOfType<GM>().chestPickedUp();
        }
    }
}
