using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private Door m_Door;
    // Start is called before the first frame update
    void Start()
    {
        m_Door = GameObject.Find("parent").GetComponent<Door>();
    }
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.name=="Box")
        {
            m_Door.OpenDoor();
        }
    }

    // Update is called once per frame
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.name == "Box")
        {
            m_Door.CloseDoor();
        }
    }
}
