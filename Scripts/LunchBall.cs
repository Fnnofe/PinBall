using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.WSA;

public class LunchBall : MonoBehaviour
{
    AreaEffector2D luncher;
    float timer = 2;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        luncher = GetComponent<AreaEffector2D>();
        currentTime = 0;


    }
    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime = currentTime - Time.deltaTime;
            Debug.Log("currentTime: " + (int)currentTime);


        }
        else luncher.enabled = false;


        if (Input.GetKey(KeyCode.Space))
        {

            LunchBalls();
        }


    }
    void LunchBalls()
    {

        luncher.enabled= true;
        currentTime = timer;


    }

}
