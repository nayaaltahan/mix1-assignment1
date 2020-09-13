using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject prefabBrick;
    public int x = 5;
    public int y = 7;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=-4;i<x;i++)
        {
            for (int j = 4; j< y; j++)
            {
                GameObject.Instantiate(prefabBrick, new Vector3(i, 0,j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
