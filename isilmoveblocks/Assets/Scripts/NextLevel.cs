using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NextLevel : MonoBehaviour
{
    public string mainMenu = "MainMenu";
    //public levelText;

    public int buildIndex = 0;
    private void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        TextMeshProUGUI levelText = GameObject.Find("LevelText").GetComponent<TextMeshProUGUI>();
        levelText.text = "Level_" + buildIndex.ToString();
    }

    public void NextLevelLoad()
    {
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");
        if (buildIndex > saveIndex)
        {
            PlayerPrefs.SetInt("SaveIndex", buildIndex);
        }



        if (buildIndex == 10)//son seviye baska seviye olmadigi icin
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(buildIndex + 1);
            Debug.Log("Level " + buildIndex);
        }

    }

    public void Menu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
