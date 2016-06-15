using UnityEngine;
using System.Collections;

public class crosshair : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
    }

	public float x = 0;
	public float y = 0;
	
	// Update is called once per frame
	void Update () {
        Vector3 mouse = Input.mousePosition;
		Vector3 position = Camera.main.ScreenToWorldPoint(mouse);
		x = mouse.x;
		y = mouse.y;
        position.z = 0;
        transform.position = position;
        if (Input.GetKey(KeyCode.Escape)) { Cursor.visible = true; }


    }
}
