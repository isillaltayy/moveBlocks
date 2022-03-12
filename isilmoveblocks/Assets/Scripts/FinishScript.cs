using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public GameObject canvas;
    //public string nextLevelMenu = "NextLevel";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            canvas.SetActive(true);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {

        canvas.SetActive(true);
        //SceneManager.LoadScene(nextLevelMenu);
        Debug.Log("Finish");
    }
}
