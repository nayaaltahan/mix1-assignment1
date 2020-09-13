using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform m_Transform;
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        //m_Transform.Translate(Vector3.left * 0.1f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        m_Transform.Translate(Vector3.forward, Space.Self);
    }
}
