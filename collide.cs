using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Asteroid1")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);

        }

    }
}