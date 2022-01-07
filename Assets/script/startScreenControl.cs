using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScreenControl : MonoBehaviour
{
    public Button start;
    public GameObject levelSelection;
    

    private void Awake()
    {
        start.onClick.AddListener(playGame);
    }

    private void playGame()
    {
        //SceneManager.LoadScene(1);
        
        levelSelection.SetActive(true);
        soundManager.Instance.Play(Sounds.ButtonClick);
    }
}
