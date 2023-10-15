using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSounds : MonoBehaviour
{
    AudioSource BallHitWall;

    void Start()
    {
        BallHitWall = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            
            BallHitWall.Play();
        }
    }

    
    void Update()
    {
        
    }

    
}
