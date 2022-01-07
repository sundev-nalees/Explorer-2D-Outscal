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
        

    }
    private void restartGame()
    {
        int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneNumber);
        soundManager.Instance.Play(Sounds.ButtonClick);
    }
    private void mainMenuScene()
    {
        SceneManager.LoadScene(levelName);
        soundManager.Instance.Play(Sounds.ButtonClick);

    }
}
