using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
 private Rigidbody enemyrb;
 private GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyrb.AddForce((lookDirection * speed)/2); //I am so crap at this game I had to slow the enemy down to test

          if (transform.position.y < -10)
        {
            Destroy (gameObject);
        }
    }
}
