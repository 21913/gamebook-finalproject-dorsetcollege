using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string SceneName;

        public void OnButton()
    {
        Debug.Log("The Next Page Button was pressed");

    }
    public void OnMouseDown()
    {
        Debug.Log("The Next Page Button was pressed");
        transform.SetAsLastSibling(); //move to the front (on parent)
        SceneManager.LoadScene(SceneName);

       // SceneManager.LoadScene("Scene4");
     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

   
}
