﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentbreakForce;
    private bool isBreaking;
    private bool isFrontLightOn;
    private bool isSirenOn;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheeTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    [SerializeField] private GameObject frontLight;
    [SerializeField] private Light redTopLight;
    [SerializeField] private Light blueTopLight;

    private float blinkRate = 2.0f; 
    private float currentTime = 0.0f;
    private float maxSirenLight = 3.0f;
    private float minSirenLight = 1.0f;
    private float defaultSirenLight = 1.0f;

    private void Update()
    {
        
        GetInput();
        TopHandleLight();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        HandleLight();
    }

    private void TopHandleLight()
    {
        currentTime += Time.fixedDeltaTime;
        float cyclePosition = Mathf.PingPong(currentTime, blinkRate) / blinkRate;
        redTopLight.intensity = Mathf.Lerp(0, defaultSirenLight, cyclePosition);
        blueTopLight.intensity = Mathf.Lerp(defaultSirenLight, 0, cyclePosition);
    }

    private void GetInput()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            isFrontLightOn = !isFrontLightOn;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            isSirenOn = !isSirenOn;
            if(isSirenOn)
            {
                defaultSirenLight = maxSirenLight;
                gameObject.GetComponent<AudioSource>().Play();
            }
            else
            {
                defaultSirenLight = minSirenLight;
                gameObject.GetComponent<AudioSource>().Stop();
            }
        }
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 0f;
        ApplyBreaking();       
    }

    private void HandleLight()
    {
        if(isFrontLightOn)
        {
            frontLight.SetActive(true);
        }
        else
        {
            frontLight.SetActive(false);
        }
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheeTransform);
        // UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        // UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot
;       wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}