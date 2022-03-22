using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class closeBtn : MonoBehaviour
{


    public void OnButton()
    {
        Debug.Log("The close button was pressed");

    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("Main");
    }



}

