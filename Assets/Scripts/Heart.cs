using UnityEngine;
using System.Collections;

public class Heart : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            gameObject.SetActive(false);
            FindObjectOfType<GM>().heartPickedUp();
        }
    }
}
