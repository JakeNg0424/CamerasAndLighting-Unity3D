using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;

    public Vector3 facing_direction = new Vector3(0.0f, 0.0f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var character_controller = this.GetComponent<CharacterController>();
        var direction =
            new Vector3(Input.GetAxis("Horizontal"),
                0.0f,
                Input.GetAxis("Vertical")).normalized;
        var delta = direction * this.speed;
        character_controller.SimpleMove (delta);

        facing_direction =
            Vector3.Lerp(direction, this.facing_direction, 0.99f);
        var transform = this.GetComponent<Transform>();
        var target = transform.position + direction;
        transform.LookAt (target);
    }
}
