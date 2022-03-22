using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    public string SceneName;

    
    public void OnMouseDown()
    {
        Debug.Log("The Next Page Button will load");
        SceneManager.LoadScene(SceneName);

        

    }


}
