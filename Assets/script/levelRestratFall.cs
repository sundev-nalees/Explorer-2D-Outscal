using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelRestratFall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerConrol>())
        {
            //level restart
            Debug.Log("level restart");
            int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneNumber);
        }
    }
}
