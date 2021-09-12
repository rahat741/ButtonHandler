using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    
    private DisplayImage currentDisplay;
    private float initialCameraSize;
    private Vector3 initialCamaeraPosition;
    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("DisplayerImage").GetComponent<DisplayImage>();
        initialCameraSize = Camera.main.orthographicSize;
        initialCamaeraPosition = Camera.main.transform.position;
    }

    public void OnRinhtClikArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }
    public void OnLeftClikArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    }

    public void OnClickZooomReturn()
    {
        if (currentDisplay.CurrentState == DisplayImage.State.zoom)
        {
            GameObject.Find("DisplayerImage").GetComponent<DisplayImage>().CurrentState = DisplayImage.State.normal;
        var zoomInObjects = FindObjectsOfType<ZoomInOtject>();
        foreach(var zoomInObject in zoomInObjects)
        {
            zoomInObject.gameObject.layer = 0;
        }

        Camera.main.orthographicSize = initialCameraSize;
        Camera.main.transform.position = initialCamaeraPosition;
        }
        else
        {
            currentDisplay.GetComponent<SpriteRenderer>().sprite
                = Resources.Load<Sprite>("Sprites/wall" + currentDisplay.CurrentWall);
            currentDisplay.CurrentState = DisplayImage.State.normal;
        }
    }
    

   
}
