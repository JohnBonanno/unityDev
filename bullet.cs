using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * 800);
    }

    public void killoldBullet()
    {
        Destroy(gameObject, 2.0f);
    }

    void onCollisionEnter(Collision collisionInfo)
    {
        Destroy(gameObject, 0.0f);
    }
}
