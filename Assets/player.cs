using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    
    // Use this for initialization
    public float speed = 1;

	private GameObject pistolStrikeObject;
	public Transform pistolStrike;

    void Start () {
		transform.rotation = Quaternion.Euler (0, 0, 0);
		//pistolStrikeObject = new 
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 player = transform.position;
		Vector3 difference = mouse - player;
		//transform.rotation = Quaternion.Euler (0, 0, (Mathf.Atan2 (difference.y, difference.x) * 180 / Mathf.PI) % 360);
		Vector3 forward = transform.rotation * Vector3.up;
		Vector3 left = transform.rotation * Vector3.left;
		Vector3 backward = transform.rotation * Vector3.down;
		Vector3 right = transform.rotation * Vector3.right;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.W)) { transform.position += forward * Time.deltaTime * speed; }
            if (Input.GetKey(KeyCode.A)) { transform.position += left * Time.deltaTime * speed; }
            if (Input.GetKey(KeyCode.S)) { transform.position += backward * Time.deltaTime * speed; }
            if (Input.GetKey(KeyCode.D)) { transform.position += right * Time.deltaTime * speed; }
        }
		if (Input.GetMouseButton(0)) {
			pistolStrike.rotation = transform.rotation;
			pistolStrike.position = transform.position + transform.rotation * Vector3.up * 10;
		}
    }
}
