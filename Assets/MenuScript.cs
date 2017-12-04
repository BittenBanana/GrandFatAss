using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    private void Awake()
    {
        Cursor.visible = true;
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Loading");
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
