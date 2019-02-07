using Assets.Scripts.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public class RiftGameController : MonoBehaviour
{
    public GameObject projectile;

    /** Called when Unity creates me */
    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /* Button checks */
        buttonCheckUpdate();

    }

    private void buttonCheckUpdate()
    {
        /* Oculus */
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Vector3 position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
            Quaternion rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
            Instantiate(projectile, position, rotation);
            Debug.Log($"Button Down: PrimaryIndexTrigger");
        }

    }


}
