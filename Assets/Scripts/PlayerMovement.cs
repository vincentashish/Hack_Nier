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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            transform.Translate(0,0,speed * Time.deltaTime);
        if(isKeyA)
            transform.Translate(-speed*Time.deltaTime,0,0);
        if(isKeyS)
            transform.Translate(0,0, -speed * Time.deltaTime);
        if(isKeyD)
            transform.Translate(speed*Time.deltaTime,0,0);
    }
}
