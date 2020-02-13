using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
//        hand = GameObject.Find("Hand");

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.active = false;
        }
    }
}
  