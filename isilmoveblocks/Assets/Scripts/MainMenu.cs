using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    string levels = "Levels";

    public void PlayGame()
    {
        SceneManager.LoadScene(levels);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionsMenu()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
