using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    private Vector3 rotation;
    [SerializeField] private float speed;


    // Update is called once per frame
    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        rotation = new Vector3(0, Input.GetAxis("Horizontal"), 0);

        if (Input.GetKey(KeyCode.A))
        {
            rotation = Vector3.up;
        }else if (Input.GetKey(KeyCode.D))
        {
            rotation = Vector3.down;
        }
        else
        {
            rotation = Vector3.zero;
        }

        transform.Rotate(rotation * speed * Time.deltaTime);

    }
}
