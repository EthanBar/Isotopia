using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

    Vector3 dragOrigin;
    Camera cam;

	// Use this for initialization
	void Start () {
        //lastPosition = new Vector2();
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            dragOrigin = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            dragOrigin = cam.ScreenToWorldPoint(dragOrigin);
        }

        if (Input.GetMouseButton(0)) {
            Vector3 currentPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            currentPos = cam.ScreenToWorldPoint(currentPos);
            Vector3 movePos = dragOrigin - currentPos;
            transform.position = transform.position + movePos;
        }
	}
}
