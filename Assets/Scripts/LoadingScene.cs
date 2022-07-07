using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public GameObject LoadScreen;
    public Slider slider;
    public Text Progress;
    private float ProgressValue;
    private AsyncOperation async = null;

    public void StartGame()
    {
        StartCoroutine(LoadScene(1));
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator LoadScene(int NextScene)
    {
        LoadScreen.SetActive(true);
        async = SceneManager.LoadSceneAsync(NextScene);
        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            if (async.progress < 0.9f)
            {
                ProgressValue = async.progress;
            }
            else
            {
                ProgressValue = 1.0f;
            }

            slider.value = ProgressValue;
            Progress.text = (int)(slider.value * 100) + " %";

            if (ProgressValue >= 0.9)
            {
                Progress.text = "請按任意按鈕繼續";
                if (Input.anyKeyDown)
                {
                    async.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }
}
