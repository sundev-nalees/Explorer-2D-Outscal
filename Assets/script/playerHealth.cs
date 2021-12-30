using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int pHealth;
    [SerializeField] private Image[] hearts;

    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            if (i < pHealth)
            {
                hearts[i].color=Color.red;
            }
            else
            {
                Destroy(hearts[i]);
            }
        }
        if (hearts[1] == null)
        {
            int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneNumber);
        }
    }
}
