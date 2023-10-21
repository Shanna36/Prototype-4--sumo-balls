using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb; 
    private GameObject focalPoint;
    public float speed = 5.0f;
    
  public bool hasPowerup = false; 

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float forceMultiplier = 0.5f;
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput * forceMultiplier);
    }

     private void onTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
    }
}

