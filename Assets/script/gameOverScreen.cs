using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverScreen : MonoBehaviour
{
    public Button restart;
    public string levelName;
    public Button mainMenu;
    private void Awake()
    {
        restart.onClick.AddListener(restartGame);
        mainMenu.onClick.AddListener(mainMenuScene);

    }
    public void playerDead()
    {
        gameObject.SetActive(true);
        Debug.Log("dead");
    }
    private void restartGame()
    {
        int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneNumber);
    }
    private void mainMenuScene()
    {
        SceneManager.LoadScene(levelName);

    }
}
