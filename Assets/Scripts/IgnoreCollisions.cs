using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisions : MonoBehaviour
{

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
      //   Physics.IgnoreCollision(ball.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log ("Success!");
            other.gameObject.GetComponent<BallMovement>().changelevel();
        }
    }
}
