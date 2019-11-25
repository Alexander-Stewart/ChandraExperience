//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CanvasController : MonoBehaviour
//{
//    // Start is called before the first frame update
//    GameObject myGO;
//    //GameObject changingText;
//    Canvas myCanvas;
//    //Text text; 
//    //RectTransform rectTransform;
//    ChangingText myText;

//    void Start()
//    {
//        //Creating Canvas 
//        myGO = new GameObject();
//        myText = new ChangingText(); 
//        myGO.name = "info container";
//        myGO.AddComponent<Canvas>();

//        //Creating canvas and text object. 
//        //Setting parent of text to canvas game object 
//        myCanvas = myGO.GetComponent<Canvas>();
//        myCanvas.renderMode = RenderMode.ScreenSpaceCamera;
//        //myText = new ChangingText();
//        myText.transform.parent = myCanvas.transform;

//    }
//    // Update is called once per frame
//    void Update()
//    {
        
//    }


//    void OnMouseUp()
//    {
//        //myText.changeText(); 
//    }

//    public Canvas getCanvas()
//    {
//        return myCanvas; 
//    }

//}
