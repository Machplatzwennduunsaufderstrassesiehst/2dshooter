using UnityEngine;
using System.Collections;

public class crosshair : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        mouse.z = 0;
        transform.position = mouse;
        if (Input.GetKey(KeyCode.Escape)) { Cursor.visible = true; }


    }
}
