using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 30f;
    public float lifeTime = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delay(5f);
        if (Input.GetKey(KeyCode.LeftShift))
        { 
            Fire();
        }
    }

    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
    }
    private void Fire()
    { 
        GameObject bullet = Instantiate(bulletPrefab);

        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletSpawn.parent.GetComponent<Collider>());

        bullet.transform.position = bulletSpawn.position;

        Vector3 rotation = bullet.transform.rotation.eulerAngles;

        bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestroyBulletAterTime(bullet, lifeTime));
    }

    private IEnumerator DestroyBulletAterTime(GameObject bullet,float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }
}
