using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    Vector3 vector = new Vector3(0, 0, 0);
    // Use this for initialization
    public float speed = 1;
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 player = transform.position;
		Vector3 difference = mouse - player;
		transform.rotation = Quaternion.Euler (0, 0, (Mathf.Atan2 (difference.y, difference.x) * 180 / Mathf.PI) % 360);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.W)) { transform.position += Vector3.up * Time.deltaTime * speed; }
            if (Input.GetKey(KeyCode.A)) { transform.position += Vector3.left * Time.deltaTime * speed; }
            if (Input.GetKey(KeyCode.S)) { transform.position += Vector3.down * Time.deltaTime * speed; }
            if (Input.GetKey(KeyCode.D)) { transform.position += Vector3.right * Time.deltaTime * speed; }
        }
    }
}
