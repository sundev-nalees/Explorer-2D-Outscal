using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelRestratFall : MonoBehaviour
{
    public gameOverScreen gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerConrol>())
        {
            //level restart
            Debug.Log("level restart");
            gameOver.playerDead();
        }
    }
}
