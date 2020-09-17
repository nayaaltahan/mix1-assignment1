using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTracker : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void DisableGravity()
    {
        rb.isKinematic = true;
    }
    
    public void EnableGravity()
    {
        rb.isKinematic = false;
    }
}
