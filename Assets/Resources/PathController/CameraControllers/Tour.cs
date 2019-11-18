using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour : MonoBehaviour
{
    
    public Pathway p1;
    public Pathway p2;
    public Pathway p3;
    public Pathway p4;
    public Pathway p5;
    public Pathway p6;
    public Pathway p7;
    public Pathway p8;
    public Pathway p9;
    public Pathway p10;
    public Pathway p11;
    public Pathway p12;

    // Start is called before the first frame update
    public static Vector3[] p1Points = new Vector3[2];
    public static Vector3[] p2Points = new Vector3[2];
    public static Vector3[] p3Points = new Vector3[6];
    public static Vector3[] p4Points = new Vector3[6];
    public static Vector3[] p5Points = new Vector3[2];
    public static Vector3[] p6Points = new Vector3[4];
    public static Vector3[] p7Points = new Vector3[11];
    public static Vector3[] p8Points = new Vector3[2];
    public static Vector3[] p9Points = new Vector3[4];
    public static Vector3[] p10Points = new Vector3[2];
    public static Vector3[] p11Points = new Vector3[2];
    public static Vector3[] p12Points = new Vector3[8];

    //public static Vector3[] pointList;
    //static Vector3 pointOne;
    //static Vector3 pointTwo;
    //static Vector3 pointThree;
    //static Vector3 pointFour;

    public static List<Pathway> pathways;
     

    void Awake()
    {
        Debug.Log("awake");

        //Assigning points to pathway
        //"pre pre orbit"  
        p1Points[0] = new Vector3(-1, -0.62f, 1.5f);
        p1Points[1] = new Vector3(-1, -0.6f, 1.5f);

        //"pre orbit" 
        p2Points[0]= new Vector3(-1, -0.6f, 1.5f);
        p2Points[1] = new Vector3(-1, -0.5f, 1.5f);

        //"tour 6" 
        p3Points[0] = new Vector3(-1f, - 0.5f, 1.5f);
        p3Points[1] = new Vector3(1.75f, - 1.6f, 1.5f);
        p3Points[2] = new Vector3(1.75f, -1.6f, -1.5f);
        p3Points[3] = new Vector3(-1f, -1.1f, -1.5f);
        p3Points[4] = new Vector3(-0.75f, -1.1f, 1.5f);
        p3Points[5] = new Vector3(0.75f, -1.1f, 1.5f);

        //"tour1a" 
        p4Points[0] = new Vector3(0.75f, -1.1f, 1.5f);
        p4Points[1] = new Vector3(-0.75f, 0.9f, 0);
        p4Points[2] = new Vector3(-2, -1.6f, 0);
        p4Points[3] = new Vector3(-0.5f, -1.4f, 0);
        p4Points[4] = new Vector3(-0.25f, -1.5f, 0);
        p4Points[5] = new Vector3(-0.25f, 1.6f, 0);

        //"tour1b" 
        p5Points[0] = new Vector3(-0.25f, -1.6f, 0f);
        p5Points[1] = new Vector3(-0.25f, 1.6f, 0.15f);

        //"tour2"
        p6Points[0] = new Vector3(-0.25f, -1.6f, 0.15f);
        p6Points[1] = new Vector3(-0.25f, 1.6f, 0);
        p6Points[2] = new Vector3(0, -1.6f, 0);
        p6Points[3] = new Vector3(0.25f, -1.6f, 0);

        //"tour3a" 
        p7Points[0] = new Vector3(0.5f, -1.6f, 0);
        p7Points[1] = new Vector3(-0.75f, -2.6f, 0);
        p7Points[2] = new Vector3(1, -1.6f, 0);
        p7Points[3] = new Vector3(2, -1.6f, 0);
        p7Points[4] = new Vector3(2, -1.2f, 0.2f);
        p7Points[5] = new Vector3(1.65f, -1.2f, 0.2f);
        p7Points[6] = new Vector3(1.2f, -1.2f, 0.2f);
        p7Points[7] = new Vector3(0.5f, -1.2f, 0.2f);
        p7Points[8] = new Vector3(0, -1.0f, 0.2f);
        p7Points[9] = new Vector3(-0.5f, -0.8f, 0.2f);
        p7Points[10] = new Vector3(-1.0f, -0.6f, 1.5f);

        //"tour3b" 
        p8Points[0] = new Vector3(-1.0f, -0.6f, 1.5f);
        p8Points[1] = new Vector3(-1.0f, -0.6f, 1.75f);

        //"tour4" 
        p9Points[0] = new Vector3(-1.0f, -0.6f, 1.75f);
        p9Points[1] = new Vector3(-1.0f, -0.6f, 1.5f);
        p9Points[2] = new Vector3(-0.5f, -1.4f, 0.2f);
        p9Points[3] = new Vector3(-0.3f, -1.9f, 0.15f);

        //"tour 5a" 
        p10Points[0] = new Vector3(-0.3f, -1.9f, 0.15f);
        p10Points[1] = new Vector3(-0.5f, -2.1f, 0.4f);

        //"tour5b"
        p11Points[0] = new Vector3(-0.5f, -2.1f, 0.4f);
        p11Points[1] = new Vector3(-0.5f, -2.1f, 0.15f);


        //"tour7" 
        p12Points[0] = new Vector3(-0.5f, -2.1f, 0.15f);
        p12Points[1] = new Vector3(-0.5f, -2.1f, -0.4f);
        p12Points[2] = new Vector3(-1, -1.6f, 1.5f);
        p12Points[3] = new Vector3(1.75f, -1.6f, 1.5f);
        p12Points[4] = new Vector3(1.75f, -1.6f, -1.5f);
        p12Points[5] = new Vector3(-1, -1.1f, -1.5f);
        p12Points[6] = new Vector3(-0.75f, -1.1f, 1.5f);
        p12Points[7] = new Vector3(-1.0f, -0.5f, 1.5f);

        //Creating pathways with additional information 
        pathways = new List<Pathway>();
        p1 = new Pathway("prepreOrbit", p1Points, 15, "preOrbit", 100, "this is path 1");
        p2 = new Pathway("preOrbit", p2Points, 15, "tour6", 100, "this is path 2");
        p3 = new Pathway("tour6", p3Points, 15, "tour1a", 100, "this is path 3");
        p4 = new Pathway("tour1a", p4Points, 15, "tour1b", 100, "this is path 4");
        p5 = new Pathway("tour1b", p5Points, 15, "tour2", 100, "this is path 5");
        p6 = new Pathway("tour2", p6Points, 15, "tour3a", 100, "this is path 6");
        p7 = new Pathway("tour3a", p7Points, 15, "tour3b", 100, "this is path 7");
        p8 = new Pathway("tour3b", p8Points, 15, "tour4", 100, "this is path 8");
        p9 = new Pathway("tour4", p9Points, 15, "tour5a", 100, "this is path 9");
        p10 = new Pathway("tour5a", p10Points, 15, "tour5b", 100, "this is path 10");
        p11 = new Pathway("tour5b", p11Points, 15, "tour7", 100, "this is path 11");
        p12 = new Pathway("tour7", p12Points, 15, "none", 100, "this is path 12");

        //Adding pathways to a list
        pathways.Add(p1); 
        pathways.Add(p2);
        pathways.Add(p3);
        pathways.Add(p4);
        pathways.Add(p5);
        pathways.Add(p6);
        pathways.Add(p7);
        pathways.Add(p8);
        pathways.Add(p9);
        pathways.Add(p10);
        pathways.Add(p11);
        pathways.Add(p12);
        //Debug.Log("awake2"); 

    }

    public List<Pathway> GetPathways()
    {
        return pathways; 
    }





}
