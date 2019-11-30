//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using PathCreation; 
////This class will get the position of the camera based on a path it has been given, and will adapt
////the text on the canvas according to the position in the path 


//public class CameraFollow : MonoBehaviour
//{
//    public PathCreator pathCreator;
//    public float speed = 5;
//    public float distanceTravelled;
//    //private Rigidbody rb; 

//    // Update is called once per frame
//    private void Start()
//    {
//        //rb = GetComponent<Rigidbody>(); 

//    }

//    void Update()
//    {
//        this.MoveAlongPath();

//    }

//    public void MoveAlongPath()
//    { 
//        distanceTravelled = speed * Time.time; 
//        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled); 
//        this.transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
//        //rb.AddForce(transform.position); 


//    }
//}
