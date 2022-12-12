using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody rb;
    string currentlvl = "Level1";
    public GameObject level;

    public GameObject Camera;

    public GameObject text;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    

    }

    // Start is called before the first frame update
    void Start()
    {
      text.SetActive(false);
      transform.position = level.transform.Find("Spawn").position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){

            Application.Quit();
 
        }
    }


 
    public void changecameradistance(){
        Camera.transform.position = new Vector3(Camera.transform.position.x, Camera.transform.position.y, Camera.transform.position.z + 2);
    }


    public void changelevel(){
        if(currentlvl == "Level1"){
            currentlvl = "Level2";
            Destroy(level);
            level = GameObject.FindWithTag(currentlvl);
            transform.position = level.transform.Find("Spawn").position;
            changecameradistance();
        } else if(currentlvl == "Level2"){
            currentlvl = "Level3";
            Destroy(level);
            level = GameObject.FindWithTag(currentlvl);
            transform.position = level.transform.Find("Spawn").position;
            changecameradistance();
        }
        else if(currentlvl == "Level3"){
            currentlvl = "Level4";
            Destroy(level);
            level = GameObject.FindWithTag(currentlvl);
            transform.position = level.transform.Find("Spawn").position;
            changecameradistance();
        }
        else if(currentlvl == "Level4"){
            
            Destroy(level);
            text.SetActive(true);

        }
    }
}