/*  Amal Presingu
 *  10/12/2021
 *  Destroying teapots after hitting the floor
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Floor")
        {
            Destroy(gameObject);
        }
    }
}
