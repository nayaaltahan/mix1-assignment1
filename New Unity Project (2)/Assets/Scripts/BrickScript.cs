using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    private GameObject _gameObject;

    private Material _material;
    // Start is called before the first frame update
    void Start()
    {
        _gameObject = GetComponent<GameObject>();
        _material = GetComponent<Material>();
    }

    public void OnCollisionEnter(Collision hit)
    {
        gameObject.SetActive(false);
    }
}
