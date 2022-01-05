using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    private static levelManager instance;
    public string level1;
    public static levelManager Instance { get { return instance; } }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        if (GetLevelStatus(level1) == levelStatus.Locked)
        {
            SetLevelStatus(level1, levelStatus.Unlocked);
        }
    }
    public void markCurrentLevelComplete()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        SetLevelStatus(currentScene.name, levelStatus.Complete);

        int nextSceneIndex = currentScene.buildIndex + 1;
        Scene nextScene = SceneManager.GetSceneByBuildIndex(nextSceneIndex);
        SetLevelStatus(nextScene.name, levelStatus.Unlocked);
    }
    public levelStatus GetLevelStatus(string level)
    {
        levelStatus levelStatus = (levelStatus)PlayerPrefs.GetInt(level, 0);
        return levelStatus;
    }
    public void SetLevelStatus(string level,levelStatus levelStatus)
    {
        PlayerPrefs.SetInt(level, (int)levelStatus);
    }
}
