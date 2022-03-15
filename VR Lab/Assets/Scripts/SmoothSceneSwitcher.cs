using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SmoothSceneSwitcher : MonoBehaviour
{
    [SerializeField] GameObject sceneSwitchCanvas;
    CanvasGroup canvasGroup;
    [SerializeField] float fadeTime = 3f;
    private void Awake()
    {
        canvasGroup = sceneSwitchCanvas.GetComponent<CanvasGroup>();
        StartCoroutine(FadeCanvasGroup(false));
    }

    public void FadeCanvasGroupWrapper(int sceneID)
    {
        StartCoroutine(FadeCanvasGroup(true,sceneID));
    }


    private IEnumerator FadeCanvasGroup(bool fade, int sceneID = 0)
    {
        float start = Time.time;
        float end = start + fadeTime;
        sceneSwitchCanvas.SetActive(true);
        if(fade)//fade = true -> show the black screen
        {
            while(Time.time <= end)
            {
                float a = Mathf.InverseLerp(start, end, Time.time);
                canvasGroup.alpha = a;
                yield return null;
            };
            SceneManager.LoadScene(sceneID);
        } else // fade = false -> hide the black screen
        {
            while (Time.time <= end)
            {
                float a = Mathf.InverseLerp(end, start, Time.time);
                canvasGroup.alpha = a;
                yield return null;
            };
            sceneSwitchCanvas.SetActive(false);
        }
    }
}
