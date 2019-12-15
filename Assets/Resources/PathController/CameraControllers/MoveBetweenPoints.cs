using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class MoveBetweenPoints : MonoBehaviour
{
    private Pathway currentPath; 
    public Rigidbody rb;
    private Vector3 target;
    private Tour tour;
    //Creating a list of points that represent a pathway
    private Vector3[] pathPoints;
    private float lerpTime; 
    private float currentLerpTime;
    private Vector3 startPos;
    float percentageComplete;
    private bool isLerping;
    private bool paused;

    private Transform EarthHigh;
    private Transform Chandra; 

    private void Awake()
    {
        tour = gameObject.AddComponent<Tour>(); 
      
    }

    void Start()
    {
        lerpTime = 10f; 
        EarthHigh = GameObject.Find("ChandraOrbit").GetComponent<Transform>();
        Chandra = EarthHigh.Find("folded-chandra").GetComponent<Transform>(); 
        rb.GetComponent<Rigidbody>();
        //isLerping = false;
        //paused = false;
        currentLerpTime = 0f;
        StartCoroutine("SetTarget");

    }


    private IEnumerator SetTarget()
    {
        Debug.Log("starting SetTarget");
        Debug.Log(Tour.pathways);
        rb.transform.position = new Vector3(Tour.pathways[0].GetPoints()[0].x, Tour.pathways[0].GetPoints()[0].y, Tour.pathways[0].GetPoints()[0].z);

        for (int p = 0; p < Tour.pathways.Count; p++)
        {
            currentPath = Tour.pathways[p];
            Debug.Log("in tour, going to next path:   " + currentPath.GetName()+ "   :   " +  p);
            for (int i = 0; i < currentPath.GetPointsLength()-1; i++)
            {

                startPos = new Vector3(currentPath.GetPoints()[i].x, currentPath.GetPoints()[i].y, currentPath.GetPoints()[i].z);
                target = new Vector3(currentPath.GetPoints()[i+1].x, currentPath.GetPoints()[i+1].y, currentPath.GetPoints()[i+1].z);
              
                yield return new WaitForSeconds(lerpTime);
                Debug.Log("going to next point: " + (i + 1));

            }
            startPos = currentPath.GetPoints()[currentPath.GetPointsLength() - 1];
            target = currentPath.GetPoints()[currentPath.GetPointsLength() - 1];
            yield return new WaitForSeconds(lerpTime);
        }

       
        StartCoroutine("SetTarget");

    }

    private void Update()
    {
        MoveToTarget();
        rb.transform.position = Chandra.TransformPoint(rb.transform.position);
        //Debug.Log("chandra pos:   " + Chandra.transform.position); 

    }


    private void MoveToTarget()

    {
        //currentLerpTime is the time since the camera left the previous point 
        //Interpolating between two the startPos and target defined in "Set Target" method 
        isLerping = true;
        currentLerpTime += Time.deltaTime;

        //The currentLerpTime should not exceed the overall time needed to interpolate between two points 
        if (currentLerpTime >= lerpTime)
        {
            currentLerpTime = lerpTime;
        }


        //Getting the interpolation step
        percentageComplete = currentLerpTime / lerpTime;
        rb.transform.position = Vector3.Lerp(startPos, target, percentageComplete);
        if (percentageComplete >= 1.0)
        {
            Debug.Log("resetting current lerp time"); 
            currentLerpTime = 0f;
            isLerping = false;
        }



    }

    private IEnumerator PauseAtPoint(float seconds)
    {
        if (!isLerping)
        {
            yield return new WaitForSeconds(seconds);
       
        }
        print("pausing at point");
        //yield return null;
        //StartCoroutine(PauseAtPoint(pauseTime));

    }

    public Pathway GetCurrentPath()
    {
        return currentPath; 
    }

}
