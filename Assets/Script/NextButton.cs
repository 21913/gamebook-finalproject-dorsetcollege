using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public void OnButton()
    {
        Debug.Log("The Next Page Button was pressed");

    }
    public void OnMouseDown()
    {
        Debug.Log("The Next Page Button was pressed");
        SceneManager.LoadScene("Scene3");

    }
}
