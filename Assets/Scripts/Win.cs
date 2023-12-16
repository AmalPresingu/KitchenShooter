/*  Amal Presingu
 *  10/12/2021
 *  Win condition (not sure if this one functions properly)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public int count;
    

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
        if (collision.transform.name == "Cannonball")
        {
            count++;
        }
        if (count >= 11)
        {
            Time.timeScale = 0;
        }
    }
}
