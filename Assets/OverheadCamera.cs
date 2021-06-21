using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverheadCamera : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var transform = this.GetComponent<Transform>();
        var camera_position = transform.localPosition;
        var player_pos = this.player.GetComponent<Transform>().position;
        var dir = (player_pos - camera_position).normalized;
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
