using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartExperience : MonoBehaviour
{
    private PlayableDirector timeline;
    private bool hasBeenActivated = false;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        InputSystem.onAButtonPressed += StartScene;
        timeline = GetComponent<PlayableDirector>();

    }

    public void StartScene() {
        if(!hasBeenActivated){
            timeline.Play();
            canvas.SetActive(false);
            hasBeenActivated = !hasBeenActivated;
        }
        
    }

    void OnDisable()
    {
        Debug.Log("PrintOnDisable: " + this.name + " was disabled");
        InputSystem.onAButtonPressed -= StartScene;
    }
}
