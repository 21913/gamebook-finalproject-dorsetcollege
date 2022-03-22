using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    public string SceneName;

    public void OnButton()
    {
        Debug.Log("The Back Page Button was pressed");

    }
    public void OnMouseDown()
    {
        Debug.Log("The Back Page Button was pressed");
        SceneManager.LoadScene(SceneName);
    }

}
