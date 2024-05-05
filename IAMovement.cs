/*
 * Author: kami-note
 * Repository: https://github.com/kami-note
 * License: Apache License
 * Creation Date: May 5, 2024
 * Last Updated: May 5, 2024
 * Description: This code is part of the RPG Orthogonal Movement AI for Unity. It provides an efficient and easy-to-use implementation for controlling the player character's movement in a grid environment, allowing precise orthogonal movements.
 */

using System.Collections.Generic;
using UnityEngine;

public class IAMovement : MonoBehaviour {
    private Dictionary<string, Vector3> directions = new Dictionary<string, Vector3> {
        { "stopped", new Vector3(0f, 0f, 0f) },
        { "forward", new Vector3(0f, 0f, 1f) },
        { "backward", new Vector3(0f, 0f, -1f) },
        { "leftward", new Vector3(-1f, 0f, 0f) },
        { "rightward", new Vector3(1f, 0f, 0f) }
    };

    public Vector3 target;
    private float speed = 5f;
    private float deadZone = 0.1f;

    public void IAHandle() {
        Vector3 playerPostion = transform.position;
        Vector3 roundedPlayerPosition = new Vector3(Mathf.Round(playerPostion.x), playerPostion.y, Mathf.Round(playerPostion.z));

        if (Mathf.Abs(roundedPlayerPosition.x - target.x) > deadZone || Mathf.Abs(roundedPlayerPosition.z - target.z) > deadZone) {
            if (Mathf.Abs(roundedPlayerPosition.x - target.x) > Mathf.Abs(roundedPlayerPosition.z - target.z)) {
                if (roundedPlayerPosition.x < target.x) {
                    transform.position += directions["rightward"] * speed * Time.deltaTime;
                } else if (roundedPlayerPosition.x > target.x) {
                    transform.position += directions["leftward"] * speed * Time.deltaTime;
                }
            } else {
                if (roundedPlayerPosition.z < target.z) {
                    transform.position += directions["forward"] * speed * Time.deltaTime;
                } else if (roundedPlayerPosition.z > target.z) {
                    transform.position += directions["backward"] * speed * Time.deltaTime;
                }
            }
        } else {
            transform.position += directions["stopped"] * speed * Time.deltaTime;
        }
    }
}
