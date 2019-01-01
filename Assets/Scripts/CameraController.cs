using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject centralCamera;
    private GameObject leftCamera;
    private GameObject rightCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject room = GameObject.Find("room");
        centralCamera = room.transform.Find("CentralCamera").gameObject;   
        leftCamera = room.transform.Find("LeftCamera").gameObject;
        rightCamera = room.transform.Find("RightCamera").gameObject;
        leftCamera.SetActive(false);
        rightCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) {
            return;
        } 
        if (centralCamera.activeSelf) {
            centralCamera.SetActive(false);
            leftCamera.SetActive(true);
            return;
        } 
        if (leftCamera.activeSelf) {
            leftCamera.SetActive(false);
            rightCamera.SetActive(true);
            return;
        }
        rightCamera.SetActive(false);
        centralCamera.SetActive(true);
    }
}
