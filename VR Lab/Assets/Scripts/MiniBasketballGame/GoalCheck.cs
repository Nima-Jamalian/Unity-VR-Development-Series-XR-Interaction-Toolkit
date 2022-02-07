using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip goalSound;
    [SerializeField] Transform ballSpawnPoistion;
    [SerializeField] MiniBasketballUIManager uIManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basketball"))
        {
            audioSource.clip = goalSound;
            audioSource.Play();
            GameObject ball = other.gameObject;
            ball.transform.position = ballSpawnPoistion.position;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            uIManager.IncreaseScore();
        }
    }
}
