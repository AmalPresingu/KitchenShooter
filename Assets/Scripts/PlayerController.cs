/*  Amal Presingu
 *  10/12/2021
 *  Programming gameplay features
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int count;
    public Text winText;
    public Text overText;
    public Button restartButton;

    public GameObject Cannonball;
    public Transform player;

    public float force;

    private bool didFire;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; //after game ends, it will start again
        count = 0;
        winText.text = "";
        overText.text = " ";
        restartButton.gameObject.SetActive(false);

        Invoke("gameOver", 30); //calling on gameOver after 60 seconds
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && (!didFire))
        {
            //GameObject bullet = Instantiate(Cannonball, player.position, player.rotation);
            //bullet.GetComponent<Rigidbody>().AddForce (-player.forward * force * Time.deltaTime);
            didFire = true;
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(Cannonball, player.position, player.rotation).GetComponent<Rigidbody>();
            projectileInstance.AddForce(player.forward * force); //launching ball
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            didFire = false;
        }
    }

    public void gameOver()
    {
        overText.text = "Game Over"; //display "game over" text
        restartButton.gameObject.SetActive(true);
        Time.timeScale = 0; //freezing game for effect; player can hit restart button after
    }

    public void OnRestartButtonPress()
    {
        SceneManager.LoadScene("Kitchen Shooter"); //restart game
    }
}
