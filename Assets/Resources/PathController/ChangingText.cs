using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChangingText : MonoBehaviour
{

    public TextMeshProUGUI mytext = null;
    private string currentPathName;
    public MoveBetweenPoints tracker; 
    
     // Start is called before the first frame update
    void Start()
    {
        //tracker= gameObject.A
        //mytext = this.getWelcomeText();
        //currentPathName = tracker.GetCurrentPath().pathName;


    }

    private void Update()
    {
        currentPathName = tracker.GetCurrentPath().pathName;
        this.ChangeOutputText(); 


    }

    public void ChangeOutputText()
    {
        switch (currentPathName)
        {
            case "prepreOrbit":
                mytext.text= "Hello from the Chandra X-Ray Observatory. The tour will start shortly. Please press the A button to return to the start of the experience. ";
                break;
             
            case "preOrbit":
                mytext.text= "";
                break;

            case "tour6":
                mytext.text= "Chandra is almost 14m long, about the size of a school bus.  It is only centimeters smaller than the largest payload the space shuttle could carry.";
                break;

            case "tour1a":
                mytext.text = "X-rays are too energetic to bounce off traditional mirrors like we use to see our reflection.";
                break;

            case "tour1b":
                mytext.text = "Instead, Chandra has nested barrel-shaped mirrors that allow the X-rays to skip like a pebble across a pond and then focus on the detector 10 meters away.";
                break;

            case "tour2":
                mytext.text = "Chandra uses cameras and spectrometers at its target to analyze the X-rays coming from deep space.";
                break;

            case "tour3a":
                mytext.text = "Chandra's solar panels collect power for the telescope's detectors and its radio communication with the Earth.";
                break;

            case "tour3b":
                mytext.text = "The electricity is also used to heat the mirrors to keep them from deforming in the cold temperatures of space.";
                break;

            case "tour4":
                mytext.text = "In order to provide motion to the observatory, Chandra has two different sets of thrusters. Chandra aims with high-precision gyroscopes.";
                break;

            case "tour5a":
                mytext.text = "The antennas on Chandra are its link to NASA's Deep Space Network, a series of three radio dishes located at different parts of Earth.";
                break;

            case "tour5b":
                mytext.text = "Once on Earth, the system delivers the data to the Chandra X-ray Center, in Cambridge, Massachusetts.";
                break;

            case "tour7":
                mytext.text = "...";
                break;


            default:
                mytext.text= "Welcome to the Chandra X-Ray Observatory";
                break;

        }
    }


    //public Text getText()
    //{
    //    return mytext; 
    //}


    //Text getWelcomeText()
    //{
    //    mytext.text = "Welcome to the Chandra Experience"; 
    //    return mytext; 
    //}


}
