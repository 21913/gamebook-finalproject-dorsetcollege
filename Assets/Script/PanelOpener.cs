using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }

        Debug.Log("The Panel will open");

    }
    public void ClosePanel()
    {
        if (Panel != null)
        {
           Panel.SetActive(false);

        }
        Debug.Log("The Panel will close");


    }




}
