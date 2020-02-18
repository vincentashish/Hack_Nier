using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("hit" + other.name + "!");
        Destroy(gameObject);
    }
}
