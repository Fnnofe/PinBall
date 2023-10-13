using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;



/// <summary>
/// 
/// </summary>
// Start is called before the first frame update

public class SpinningPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float spinSpeed=100f;
    [SerializeField] bool isReversed = false;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        if (isReversed == true)
        {
            spinSpeed = spinSpeed * -1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
                {
            Spinning();

        }



    }


    void Spinning()
    {
        rb.angularVelocity = spinSpeed*10;

    }
}
