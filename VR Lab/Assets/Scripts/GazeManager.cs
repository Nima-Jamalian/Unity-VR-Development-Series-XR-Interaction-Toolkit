using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeManager : MonoBehaviour
{
    [SerializeField] float gazeCompletionTime = 5.0f;
    float orignalGazeCompletionTime;
    [SerializeField] Image gazeReticle;
    [SerializeField] GameObject gazeReticleBackground;
    bool hasCalledGazeCompletion = false;
    GazeTarget currentGazeTarget,previousGazeTarget;

    private void Start()
    {
        orignalGazeCompletionTime = gazeCompletionTime;
    }
    private void FixedUpdate()
    {
        RaycastHit raycastHit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out raycastHit, Mathf.Infinity))
        {
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * raycastHit.distance, Color.yellow);
            //Debug.Log("Raycast did hit: " + raycastHit.transform.name);
            currentGazeTarget = raycastHit.transform.GetComponent<GazeTarget>();
            if(currentGazeTarget != null && currentGazeTarget != previousGazeTarget)
            {
                if(previousGazeTarget != null)
                {
                    GazeExit();
                }
                Debug.Log("Gaze Enter got called");
                currentGazeTarget.GazeEnter();
                previousGazeTarget = currentGazeTarget;

            } else if (currentGazeTarget != null && currentGazeTarget == previousGazeTarget)
            {
                gazeCompletionTime -= Time.deltaTime;
                gazeReticleBackground.SetActive(true);
                gazeReticle.fillAmount = Mathf.Lerp(gazeReticle.fillAmount, 1f, (1/gazeCompletionTime) * Time.deltaTime);
                if (gazeCompletionTime <= 0f && hasCalledGazeCompletion == false)
                {
                    hasCalledGazeCompletion = true;
                    Debug.Log("Gaze Completion got called");
                    currentGazeTarget.GazeCompletion();
                }
            } else if (currentGazeTarget == null && previousGazeTarget != null)
            {
                GazeExit();
            }
        } else
        {
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 1000, Color.white);
            //Debug.Log("Did not Hit");
            if(previousGazeTarget != null)
            {
                GazeExit();
            }
        }
    }
    void GazeExit()
    {
        Debug.Log("Gaze Exit got called");
        previousGazeTarget.GazeExit();
        previousGazeTarget = null;
        gazeCompletionTime = orignalGazeCompletionTime;
        hasCalledGazeCompletion = false;
        gazeReticle.fillAmount = 0;
        gazeReticleBackground.SetActive(false);
    }
}


