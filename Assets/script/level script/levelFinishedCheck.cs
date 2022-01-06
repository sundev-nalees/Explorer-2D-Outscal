using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelFinishedCheck : MonoBehaviour
{
    public gameOverScreen gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerConrol>()) 
        {
            //level complete
            Debug.Log("level finished");
            
            //int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
           // SceneManager.LoadScene(currentSceneNumber + 1);
           
            gameOver.playerDead();
            levelManager.Instance.markCurrentLevelComplete();
        }
    }
}
