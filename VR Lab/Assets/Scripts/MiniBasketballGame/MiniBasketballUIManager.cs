using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniBasketballUIManager : MonoBehaviour
{
    [SerializeField] Animator doorAnimation;
    [SerializeField] Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartGameButtonClick()
    {
        doorAnimation.SetBool("StartGame", true);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
