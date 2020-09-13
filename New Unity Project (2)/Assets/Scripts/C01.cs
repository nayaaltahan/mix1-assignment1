using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C01 : MonoBehaviour
{
    public Transform m_Transform;
    public Rigidbody m_Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("01");
        m_Transform = gameObject.GetComponent<Transform>();
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //m_Transform.Translate(Vector3.forward*0.1f,Space.Self);
        if (Input.GetKey(KeyCode.W))
        {
            //m_Transform.Translate(Vector3.forward * 0.1f, Space.Self);
            m_Rigidbody.MovePosition(m_Transform.position +Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //m_Transform.Translate(Vector3.left * 0.1f, Space.Self);
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //m_Transform.Translate(Vector3.back * 0.1f, Space.Self);
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.back * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //m_Transform.Translate(Vector3.right * 0.1f, Space.Self);
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.right * 0.1f);
        }
    }

/*    void OnCollisionEnter(Collision  coll)
    {
        Debug.Log("peng" + coll.gameObject.name);

    }*/

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("dong" + coll.gameObject.name);
    }
}
