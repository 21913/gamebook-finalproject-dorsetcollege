using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class userProfile : MonoBehaviour
{
    public void OnButton()
    {
        Debug.Log("User Profile was pressed");

    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("UserDetails");
    }

}
