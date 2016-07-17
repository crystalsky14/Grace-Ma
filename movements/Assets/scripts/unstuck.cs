using UnityEngine;
using System.Collections;

public class unstuck : MonoBehaviour
{
    public int collisioncount=0 ;
    private float constantup = 0.05f;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        collisioncount = -3; 
    }

    // Update is called once per frame
    void Update()
    {
        if (collisioncount > 0 )
        {
            player.transform.Translate(Vector3.up * constantup);
            movementplayer.once = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        collisioncount++;

    }
    void OnTriggerExit(Collider other)
    {
        collisioncount--;
    }
}
