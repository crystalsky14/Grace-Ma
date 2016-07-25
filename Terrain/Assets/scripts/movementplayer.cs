using UnityEngine;
using System.Collections;

public class movementplayer : MonoBehaviour
{
    float translatenumber = .3f;
    float translatenumber2 = -.12f;
    float forward = 1f;
    static public bool once = true; 
    public int speed = 10;
    public float turnSpeed = 100f;
    public int turncount = 2;
    float constantdown = 0.05f;
    public bool onwall = true;
    bool exit = false; 
    bool rotate = false; // dfgdfbfdbfdbfbf
    bool onceclick = true;
    bool onceturn = true; 
  
   
    public int collisioncount = 0;
    // Use this for initialization
    void Start()
    {
        collisioncount = -3; 
        turncount = 2;
        Screen.lockCursor = true;
        exit = false; 
        rotate = false;//dfbfbdbdffdfdbbdbdffdb
    }

    // Update is called once per frame
    void Update()
    {
      
            if (Input.GetKey(KeyCode.W)&& driveupwalls.stop == false&& onceturn == true)
        {
            once = true;
            onceclick = true; 
           
            transform.Translate(Vector3.forward * speed * Time.deltaTime); 
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (driveupwalls.stop == true)
            {
                turncount++; 
            }
            transform.Rotate(Vector3.up, -90);
            onceturn = false; 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (driveupwalls.stop == true)
            {
                turncount--;
            }
            transform.Rotate(Vector3.up, 90);
            onceturn = false; 
        }
       
        if ((Input.GetMouseButtonDown(0)) && driveupwalls.stop == true&& (turncount - (turncount / 4 * 4) == 2)&& onceclick == true)
        {
            if (onwall == true)
            {
                transform.Rotate(Vector3.left, 90);
               
                transform.Translate(Vector3.forward * forward);
                movementplayer.once = false;
                rotate = true; // aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
              //  driveupwalls.stop = false;
               
            }
            if (onwall == false)
            {
                transform.Rotate(Vector3.left, -90);
                //  transform.Translate(Vector3.up * translatenumber2);
                transform.Translate(Vector3.forward * 1);
                movementplayer.once = false;
                rotate = true; // aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                               //  driveupwalls.stop = false;
                onwall = true;
           
              
            }
            onceclick = false; 

        }
        if (Input.GetKeyDown(KeyCode.W)) // aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        {
            if (rotate == true)
            {
                driveupwalls.stop = false;
                rotate = false;
            }
            else
            {
                onceturn = true;
            }
        }
        if (exit == true) 
        {
            transform.Translate(Vector3.forward * constantdown);
            if (collisioncount == 0)
            {
                onwall = false;
            
            }
            else
                driveupwalls.stop =false;
            exit = false;
          //  transform.Translate(Vector3.forward * -constantdown);

        }
        if ((turncount - (turncount/ 4 * 4) == 0|| turncount == 0)&& Input.GetKey(KeyCode.W) )
        {
          once = false;
                transform.Translate(Vector3.forward * forward);
           
          
            driveupwalls.stop = false;
               turncount = 2;

            
        }
        if (collisioncount == 0) 
        {
            transform.Translate(Vector3.down * constantdown );
       
        }
       

      

    }
    void OnTriggerEnter(Collider other)
    {
        collisioncount++;
     
    
    }       
          
 
    
    void OnTriggerExit(Collider other)
    {  collisioncount--; 
    if (once == true)
        {
            driveupwalls.stop = true;
           
            exit = true;  
       
         
            once = false; 
        }
         
        
        
    } 

}