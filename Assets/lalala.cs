using UnityEngine;

public class lalala : MonoBehaviour {
    Animator anim;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * (10 * Time.deltaTime));
    }
}
