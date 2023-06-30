using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle2 : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Enter"))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        if (cam1.activeSelf)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

    }
}