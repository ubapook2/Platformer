using UnityEngine;
using System.Collections;

public class PatrolMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    Vector3 direction = Vector3.left;

    // Update is called once per frame
    void Update()
    {

        transform.position += direction * Time.deltaTime;

        if (transform.position.x <= -1)
        {
            direction = new Vector3(1, .3f);
        }
        if (transform.position.x >= 6)
        {
            direction = new Vector3(-1, -.3f);
        }

    }

}