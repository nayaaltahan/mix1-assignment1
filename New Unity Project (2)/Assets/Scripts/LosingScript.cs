using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Ball"))
        {
            
        }
    }
}
