using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var enemies = FindObjectsOfType<Enemy>();
        if (enemies != null)
        { 
            transform.parent.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
