using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    public GameObject[] Cameras;
    private int currentCamera = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // turn off current camera, then cycle to the next camera in array, if it's the last return to the first
        Cameras[currentCamera].SetActive(false);
        if (currentCamera == (Cameras.Length - 1))
        {
            currentCamera = 0;
        }
        else
        {
            currentCamera++;
        }
        Cameras[currentCamera].SetActive(true);
    }
}