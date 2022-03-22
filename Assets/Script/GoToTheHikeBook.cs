using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToTheHikeBook : MonoBehaviour
{
    public void OnButton()
    {
        Debug.Log("The Book `The Hike` was pressed");
 
       }
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Scene1");


    }

}
