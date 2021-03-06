using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
    {
    public static GameManager instance;

    void Awake()
        {
            if (instance != null)
            {
                Debug.LogErrorFormat(gameObject,
                "Multiple instances of {0} is not allow", GetType().Name);
                DestroyImmediate(gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
            instance = this;
        }

    public void StartGame()
    {
        SceneManager.LoadScene("LoadingScece");
    }
    public void Exit()
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }

    public void EndGame()
    {
        SceneManager.LoadScene("LoadingScece");
        StartCoroutine("LoadScene");
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Start is called before the first frame update
    void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
