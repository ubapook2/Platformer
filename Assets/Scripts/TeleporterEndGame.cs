using UnityEngine;
using System.Collections;

public class TeleporterEndGame : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            FindObjectOfType<GM>().youWin();
        }
    }
}
