using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    public Transform ballStart;
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.tag == "Goal")
        {
            //Invoke("LoadScene", 0.0001f);
            transform.position = ballStart.transform.position;
            ballStart.gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
        }
    }
}
