using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boardMarker5 : MonoBehaviour
{

    // --------------------------------->
    // SET VARIABLES
    // --------------------------------->

    public GameObject DuckModelReference;
    public GameObject reference_boardMarker5;
    public GameObject reference_boardMarker1Label;
    public GameObject reference_boardMarker2Label;
    public GameObject reference_boardMarker3Label;
    public GameObject reference_boardMarker4Label;
    public GameObject reference_boardMarker5Label;

    public Vector3 duckPosition;

    private MeshRenderer boardMarkerColor;

    public bool CanSetVisibility = false;
    public bool isPressed = false;
    public bool isReleased = false;
    public bool isVisible = true;
    public bool isHidden = false;

    // --------------------------------->

    


    // --------------------------------->
    // BUILT-IN FUNCTIONS
    // --------------------------------->

    void Start() { boardMarkerColor = GetComponent<MeshRenderer>(); }
    void Update() { VisibilityCheck(); }

    private void VisibilityCheck()
    {
        if (isPressed == true)
        {
            boardMarkerColor.material.color = Color.red;

            reference_boardMarker1Label.SetActive(false);
            reference_boardMarker2Label.SetActive(false);
            reference_boardMarker3Label.SetActive(false);
            reference_boardMarker4Label.SetActive(false);
            reference_boardMarker5Label.SetActive(true);

            DuckModelReference.transform.position = reference_boardMarker5.transform.position;
        }

        else if (isPressed == false)
        {
            CanSetVisibility = false;
            GetComponent<Renderer>().enabled = true;
        }
    }

    // ---------------------------------->
    // ADDITIONAL FUNCTIONS
    // ---------------------------------->
    public void OnMouseUp()   { isPressed = false; }  
    public void OnMouseDown() { isPressed = true; }
    
    public void SetVisibility()
    {
        if (CanSetVisibility == true)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }

    // ----------------------------------->

}
