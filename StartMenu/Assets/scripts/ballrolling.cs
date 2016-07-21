using UnityEngine;
using System.Collections;

public class ballrolling : MonoBehaviour {

	// Use this for initialization
	
 
    public float turnSpeed = 10f;



// Update is called once per frame
void Update()
{

    if (Input.GetKey(KeyCode.W))
        transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);

   // if (Input.GetKey(KeyCode.S))
       // transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
       /* if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(Vector3.down, 90);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Vector3.up, -90);
        } */
    }
}
