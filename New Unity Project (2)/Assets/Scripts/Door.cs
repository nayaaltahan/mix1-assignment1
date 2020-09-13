using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform m_Transform;

    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            OpenDoor();
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            CloseDoor();
        }
    }
    public void OpenDoor()
    {
        m_Transform.Rotate(Vector3.up, -90);
    }
    public void CloseDoor()
    {
        m_Transform.Rotate(Vector3.up, 90);
    }
}
