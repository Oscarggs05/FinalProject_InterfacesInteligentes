using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string selectedScene;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void LoadMap(string sceneName)
    {
        selectedScene = sceneName;
        SceneManager.LoadScene(sceneName);
        UnityEngine.Debug.Log(sceneName + "Loaded");
    }
}

