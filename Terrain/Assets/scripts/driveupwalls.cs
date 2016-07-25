using UnityEngine;
using System.Collections;

public class driveupwalls : MonoBehaviour { 
 public GameObject player;
    float translatenumber = .5f;
    float translatenumber2 = 1.3f;
    float translatenumber3 = .5f;
    static public bool stop = false;
    public int collisioncount = 0;

    // Use this for initialization
    void Start () {
        collisioncount = -3;

    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.Space) && stop == true)
         {
             player.transform.Rotate(Vector3.left, 90);
             player.transform.Translate(Vector3.down * translatenumber);
             player.transform.Translate(Vector3.forward * translatenumber);
             movementplayer.once = false;

         }
         */
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            stop = true;

          //  collisioncount++;

            /*if (Input.GetKey(KeyCode.S))

            {
                player.transform.Rotate(Vector3.left, -90);
                player.transform.Translate(Vector3.down * translatenumber2);
                player.transform.Translate(Vector3.forward * -translatenumber3);
            }
            // player.transform.Translate(Vector3.back * 5); */

        }
       
    }
    void OnTriggerExit(Collider other)
    {
      //  collisioncount--;
    }
    }
