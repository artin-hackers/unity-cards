using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    private int speedMultiplier = 1;

    private void Update() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W)) {
            rigidbody.velocity = transform.forward * 3f * speedMultiplier;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.velocity = transform.forward * -3f;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, -1f, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            speedMultiplier = 3;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            speedMultiplier = 1;
        }
    }
}
