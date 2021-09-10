using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{

    private DisplayImage currentDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("DisplayerImage").GetComponent<DisplayImage>();
        
    }

    public void OnRinhtClikArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }
    public void OnLeftClikArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    }

   
}
