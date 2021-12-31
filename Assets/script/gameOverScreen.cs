using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverScreen : MonoBehaviour
{
    public Button restart;

    private void Awake()
    {
        restart.onClick.AddListener(restartGame);
    }
    public void playerDead()
    {
        gameObject.SetActive(true);
    }
    private void restartGame()
    {
        int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneNumber);
    }
}
