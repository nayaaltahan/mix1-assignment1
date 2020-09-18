using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSpherePosition : MonoBehaviour
{
    private Transform _transform;
    private Vector3 _defaultPosition;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        var currentPosition = _transform.position;
        _defaultPosition = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);;
    }

    public void ResetPosition()
    {
        _transform.position = _defaultPosition;
    }

}
