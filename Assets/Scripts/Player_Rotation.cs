using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float torque = 100f;
    public float turn = 1000f;
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
            if (isArrowU)
                rb.AddTorque(transform.forward * torque * turn);
          /*if (isArrowD)
                transform.Rotate(0, 0, 180f);
            if (isArrowL)
                transform.Rotate(0, 0, 90f);
            if (isArrowR)
                transform.Rotate(0, 0, 90f);
           */
        }
    }
}
