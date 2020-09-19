using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Ball"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}
