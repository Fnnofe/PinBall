using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    AudioSource ScoreSound;

    void Start()
    {
        ScoreSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ScoreSound.Play();
            //Destroy(gameObject);
            
            ScoreManager.instance.AddPoint();
            
        }
    }
}
