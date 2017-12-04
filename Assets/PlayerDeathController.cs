using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathController : MonoBehaviour
{

    public GameObject WastedObject;
    public GameObject PoliceEffect;
    public GameObject EneFatGUI;
    public GameObject Player;

    bool isDead = false;
    float timer = 0;


    private void Update()
    {
        if (isDead)
        {
            timer += Time.deltaTime;
            if (timer >= 1.5f)
            {
                WastedObject.SetActive(true);
                PoliceEffect.SetActive(false);
                EneFatGUI.SetActive(false);
                Player.GetComponent<PlayerController>().enabled = false;
                GetComponent<GameTimer>().CanCount = false;
            }
            if(Input.GetKeyDown(KeyCode.Escape))
            {

                Time.timeScale = 1f;
                SceneManager.LoadScene("New Scene");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("layout");
            }
        }
    }
    public void Wasted()
    {
        isDead = true;

    }
}
