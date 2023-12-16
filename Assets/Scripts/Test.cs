/*  Amal Presingu
 *  10/12/2021
 *  Win condition + collision detection
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public Text winText;
    public Button restartButton;
    public float forceApplied = -250;
    


    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
        Time.timeScale = 1;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "default")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0); //adding gravity to teapots
            //GetComponent<Rigidbody>().useGravity = true;
            KeepScore.Score += 1;
        }
        if (KeepScore.Score >= 11)
        {
            Time.timeScale = 0; //freezing game for effect; player can hit restart button after
            restartButton.gameObject.SetActive(true);
            KeepScore.Score = 0;
            winText.text = "You win"; //display winning text    
        }

    }

}
