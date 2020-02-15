using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    
    public float speed = 0.03f;
    public bool isKeyD = false;
    public bool isKeyA = false;
    public bool isKeyW = false;
    public bool isKeyS = false;
    public bool isArrowR = false;
    public bool isArrowL = false;
    public bool isArrowU = false;
    public bool isArrowD = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isArrowR = false;
        isArrowL = false;
        isArrowU = false;
        isArrowD = false;
        isKeyD = false;
        isKeyA = false;
        isKeyS = false;
        isKeyW = false;
        if (Input.GetKey(KeyCode.D))
            isKeyD = true;
        if (Input.GetKey(KeyCode.A))
            isKeyA = true;
        if (Input.GetKey(KeyCode.W))
            isKeyW = true;
        if (Input.GetKey(KeyCode.S))
            isKeyS = true;
        if (Input.GetKey(KeyCode.D))
            isKeyD = true;
    }
    
    void FixedUpdate() 
    {
        if(isKeyW)
            transform.Translate(0,-speed*Time.deltaTime,0);
        if(isKeyA)
            transform.Translate(-speed*Time.deltaTime,0,0);
        if(isKeyS)
            transform.Translate(0,speed*Time.deltaTime,0);
        if(isKeyD)
            transform.Translate(speed*Time.deltaTime,0,0);
    }
}
