﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChange;
    public event System.Action OnSceneChange; 

    private void Awake()
    {
        SingletonThisGameObject();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {
        score += 12;
        OnScoreChange?.Invoke(score);
    }

    public void StartGame()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(StartGameAsync());
    }

    private IEnumerator StartGameAsync()
    {
        OnSceneChange?.Invoke();

        yield return SceneManager.LoadSceneAsync("Game");
    }  

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReturnMenu()
    {
        StartCoroutine(ReturnMenuAsync());
    }

    public IEnumerator ReturnMenuAsync()
    {
        OnSceneChange?.Invoke();

        yield return SceneManager.LoadSceneAsync("Menu");
    }
}
