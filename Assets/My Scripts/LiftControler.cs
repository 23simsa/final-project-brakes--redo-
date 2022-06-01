using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftControler : MonoBehaviour
{
    public XRButton upButton;
    public GameObject platform;
    public float platformSpeed = .2f;
    

    // Update is called once per frame
    void Update()
    {
        if (upButton.isHovered)
        {
            platform.transform.Translate(Vector3.up * Time.deltaTime * platformSpeed, Space.World);
        }
    }     
   
    public void ButtonPushed()
    {
        Debug.Log("you pushed the button! ");
    }
}