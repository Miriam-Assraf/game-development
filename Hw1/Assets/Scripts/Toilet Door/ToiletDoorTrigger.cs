﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDoorTrigger : MonoBehaviour
{
    private DoorMotion doorMotion;

    // Start is called before the first frame update
    void Start()
    {
        doorMotion = GameObject.Find("Toilet Door Axis").GetComponent<DoorMotion>();
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