using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*150,Input.GetAxis("Vertical")*150);
        //check library on screen joypad helper android

    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("touched");

        if (other.tag == "waterfall")
        {
            SceneManager.LoadScene("WinnerScene");

        }
    }



}

