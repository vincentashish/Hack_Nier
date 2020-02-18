using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float torque = 100f;
    //float turn = Input.GetAxis("Horizontal");
    public bool isArrowR = false;
    public bool isArrowL = false;
    public bool isArrowU = false;
    public bool isArrowD = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isArrowR = false;
        isArrowL = false;
        isArrowU = false;
        isArrowD = false;
        if (Input.GetKey(KeyCode.UpArrow))
            isArrowU = true;
        if (Input.GetKey(KeyCode.DownArrow))
            isArrowD = true;
        if (Input.GetKey(KeyCode.LeftArrow))
            isArrowL = true;
        if (Input.GetKey(KeyCode.RightArrow))
            isArrowR = true;
    }


    void FixedUpdate()
    {
        if (isArrowU || isArrowR || isArrowL || isArrowD)
        {
            ForceMode mode;
            //if (isArrowU)
                //rb.AddTorque(transform.forward * torque * turn
            //if (isArrowD)
                //rb.AddTorque(0, -torque, 0, mode = ForceMode.Force);
            if (isArrowL)
                rb.AddTorque(0, -torque, 0, mode = ForceMode.Force);
            if (isArrowR)
                rb.AddTorque(0, torque, 0, mode = ForceMode.Force);
             
        }
    }
}
