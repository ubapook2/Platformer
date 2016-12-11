using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            Application.LoadLevel("Level Two");
        }
    }
}
