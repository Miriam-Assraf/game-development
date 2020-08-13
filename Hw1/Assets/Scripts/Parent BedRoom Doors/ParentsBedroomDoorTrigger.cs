﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentsBedroomDoorTrigger : MonoBehaviour
{
    private DoorMotion doorMotion;

    // Start is called before the first frame update
    void Start()
    {
        doorMotion = GameObject.Find("Parents Bedroom Door Axis").GetComponent<DoorMotion>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("MainCamera")) // if main camera enters collider
        {
            doorMotion.OpenDoor();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        doorMotion.CloseDoor();
    }

}