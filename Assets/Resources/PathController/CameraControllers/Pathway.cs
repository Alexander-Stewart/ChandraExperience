using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathway : MonoBehaviour
{
    public Vector3[] pointList;
    public int duration;
    public string nextPath;
    public int pauseTime;
    public string textDisplay;
    public string pathName; 


    // Start is called before the first frame update
    public Pathway(string name, Vector3[] points, int dur, string next, int pause, string text)
    {
        pointList= points; 
        duration= dur; 
        nextPath= next; 
        pauseTime= pause; 
        textDisplay= text;
        pathName = name; 
    }


    public Vector3[] GetPoints()
    {
        return pointList; 
    }

    public int GetPointsLength()
    {
        return pointList.Length;

    }

    public string GetText()
    {
        return textDisplay; 
    }

    public string GetName()
    {
        return pathName; 
    }


    


}
