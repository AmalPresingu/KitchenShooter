/*  Amal Presingu
 *  10/12/2021
 *  Controlling camera movements
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 10.0f;

    public Transform upperBounds;
    public Transform lowerBounds;
    public Transform rightBounds;
    public Transform leftBounds;
    public CameraController m_FPS;
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

      


        if (m_FPS.enabled)
        {

            if (Input.GetKey(KeyCode.W) && (transform.position.y < upperBounds.position.y)) //I don't have arrow keys on my keyboard, so I made the option for both for easier testing purposes
            {
                transform.position += (transform.up * Time.deltaTime * speed); //moving camera up
            }
            if (Input.GetKey(KeyCode.S) && (transform.position.y > lowerBounds.position.y))
            {
                transform.position += (-transform.up * Time.deltaTime * speed); //moving camera down
            }
            if (Input.GetKey(KeyCode.A) && (transform.position.x > leftBounds.position.x))
            {
                transform.position += (-transform.right * Time.deltaTime * speed); //moving camera left
            }
            if (Input.GetKey(KeyCode.D) && (transform.position.x < rightBounds.position.x))
            {
                transform.position += (transform.right * Time.deltaTime * speed); //moving camera right
            }
            if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < upperBounds.position.y))
            {
                transform.position += (transform.up * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > lowerBounds.position.y))
            {
                transform.position += (-transform.up * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > leftBounds.position.x))
            {
                transform.position += (-transform.right * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < rightBounds.position.x))
            {
                transform.position += (transform.right * Time.deltaTime * speed);
            }
        }
    }
}
