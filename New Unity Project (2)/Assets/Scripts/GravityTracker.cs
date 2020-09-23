using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTracker : MonoBehaviour
{
    private Rigidbody rb;

    private ConstantForce _constantForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _constantForce = GetComponent<ConstantForce>();
    }

    public void EnableKinematic()
    {
        rb.isKinematic = true;
    }
    
    public void DisableKinematic()
    {
        rb.isKinematic = false;
    }

    void FixedUpdate()
    {
        rb.velocity = Vector3.Normalize(rb.velocity) * 40;
    }
    
    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player") 
            && _constantForce.force != Vector3.forward)
        {
            rb.velocity = Vector3.forward;
            _constantForce.force = Vector3.forward;
            DisableKinematic();
        }
    }
}
