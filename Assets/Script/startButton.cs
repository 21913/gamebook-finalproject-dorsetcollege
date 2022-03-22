using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public void OnButton()
    {
        Debug.Log("The Book `The Hike` will open");

    }
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Scene2");


    }

}