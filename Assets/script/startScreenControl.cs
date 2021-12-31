using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScreenControl : MonoBehaviour
{
    public Button start;

    private void Awake()
    {
        start.onClick.AddListener(playGame);
    }

    private void playGame()
    {
        SceneManager.LoadScene(1);
    }
}
