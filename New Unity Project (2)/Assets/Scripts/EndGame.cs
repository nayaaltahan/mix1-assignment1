using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EndGame : MonoBehaviour
{
    public static GameObject Text;

    void Start()
    {
        Text = GameObject.Find("End");
        Text.SetActive(false);
    }
}
