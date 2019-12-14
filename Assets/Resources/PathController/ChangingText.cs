using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangingText : MonoBehaviour
{

    public TextMeshProUGUI mytext = null;
    //public AudioSource audioSource;  
    private string currentPathName;
    public MoveBetweenPoints tracker; 

    //make sure audio clips are public 
    //public AudioClip audio1;
    //public AudioClip audio2;
    //public AudioClip audio3;
    //public AudioClip audio4;
    //public AudioClip audio5;
    //public AudioClip audio6;
    //public AudioClip audio7;
    //public AudioClip audio8;
    //public AudioClip audio9;
    //public AudioClip audio10;
    
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

    public Text ChangeOutputText()
    {
        switch (currentPathName)
        {
            case "prepreOrbit":
                mytext.text= "Hello from the Chandra X-Ray Observatory. The tour will start shortly. Please press the A button to return to the start of the experience. ";
                //audioSource.PlayOneShot(audio1);
                break;
             
            case "preOrbit":
                mytext.text= "Please enjoy the experience!";
                break;

            case "tour6":
                mytext.text= "Chandra is almost 14m long, about the size of a school bus.  It is only centimeters smaller than the largest payload the space shuttle could carry.";
                //audioSource.PlayOneShot(audio2);
                break;

            case "tour1a":
                mytext.text = "X-rays are too energetic to bounce off traditional mirrors like we use to see our reflection.";
                //audioSource.PlayOneShot(audio3);
                break;

            case "tour1b":
                mytext.text = "Instead, Chandra has nested barrel-shaped mirrors that allow the X-rays to skip like a pebble across a pond and then focus on the detector 10 meters away.";
                //audioSource.PlayOneShot(audio4);
                break;

            case "tour2":
                mytext.text = "Chandra uses cameras and spectrometers at its target to analyze the X-rays coming from deep space.";
                //audioSource.PlayOneShot(audio5);
                break;

            case "tour3a":
                mytext.text = "Chandra's solar panels collect power for the telescope's detectors and its radio communication with the Earth.";
                //audioSource.PlayOneShot(audio6);
                break;

            case "tour3b":
                mytext.text = "The electricity is also used to heat the mirrors to keep them from deforming in the cold temperatures of space.";
                //audioSource.PlayOneShot(audio7);
                break;

            case "tour4":
                mytext.text = "In order to provide motion to the observatory, Chandra has two different sets of thrusters. Chandra aims with high-precision gyroscopes.";
                //audioSource.PlayOneShot(audio8);
                break;

            case "tour5a":
                mytext.text = "The antennas on Chandra are its link to NASA's Deep Space Network, a series of three radio dishes located at different parts of Earth.";
                //audioSource.PlayOneShot(audio9);
                break;

            case "tour5b":
                mytext.text = "Once on Earth, the system delivers the data to the Chandra X-ray Center, in Cambridge, Massachusetts.";
                //audioSource.PlayOneShot(audio10);
                break;

            case "tour7":
                mytext.text = "...";
                return mytext;

            default:
                mytext.text= "Welcome to the Chandra X-Ray Observatory";
                return mytext; 

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
