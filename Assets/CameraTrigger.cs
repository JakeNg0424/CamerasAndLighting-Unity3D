using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public string room_name = "untitled";

    public Camera room_camera;

    public Camera main_camera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Player>() != null)
        {
            Debug.Log("You're in " + room_name);
            this.main_camera.enabled = false;
            this.room_camera.enabled = true;
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<Player>() != null)
        {
            Debug.Log("You're leaving " + room_name);
            this.main_camera.enabled = true;
            this.room_camera.enabled = false;
        }
    }
}
