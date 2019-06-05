using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
{
    private PlayerMovement pmove;

    void Start()
    {
        pmove = FindObjectOfType<PlayerMovement>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        pmove.rb.velocity = new Vector3(0,0,0);
        pmove.isMoving = false;            
    }
}
