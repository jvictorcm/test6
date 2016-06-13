using UnityEngine;
using System.Collections;

public class RotateAroundX : MonoBehaviour {


    ///////////////////////////////////////////////////////////////////////////////////
    //Vector3 rotationMask = new Vector3(1, 1, 1); //which axes to rotate around
    //float rotationSpeed = 5.0f; //degrees per second
   // Transform rotateAroundObject;
    public GameObject cube;
    ///////////////////////////////////////////////////////////////////////////////////
    // Use this for initialization
    void Start () {
        //cube = GameObject.FindGameObjectsWithTag("Centro");
        cube = GameObject.FindGameObjectWithTag("Camera");
        //rotateAroundObject = cube.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        //float translation = Input.GetAxis("VerticalJoy") * 10;
        //float rotation = Input.GetAxis("HorizontalJoy") * 10;
        //transform.RotateAround(rotateAroundObject.transform.position,
        //rotationMask, rotationSpeed * Time.deltaTime);
        if (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3") || Input.GetButton("HorizontalJoy") || Input.GetButton("VerticalJoy"))
        {
            cube.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
            //print("foi");
        }
    }


    //void FixedUpdate()
   // {
      // if (rotateAroundObject)
      //  {//If true in the inspector orbit <rotateAroundObject>:
            
     //   }
      //  else
     //   {//not set -> rotate around own axis/axes:
     //       transform.Rotate(new Vector3(
      //      rotationMask.x * rotationSpeed * Time.deltaTime,
      //      rotationMask.y * rotationSpeed * Time.deltaTime,
      //      rotationMask.z * rotationSpeed * Time.deltaTime));
      //  }
    //}
}
