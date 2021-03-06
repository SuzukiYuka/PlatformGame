﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {

    public GameObject mainCamera;
    public bool isGoal = false;
    public float overCameraSize = 23f;
    public StageController stageController;
    float cameraSize;
    float deltaCameraSize;
    float smoothTime = 1.5f;
    CameraFollow cameraFollow;
    Camera cameraComponent;
    Vector3 velocity = Vector3.zero;
    float cameraSizeVelocity = 0;

    void Start() {
        cameraFollow = mainCamera.GetComponent<CameraFollow>();
        cameraComponent = mainCamera.GetComponent<Camera>();
        cameraSize = cameraComponent.orthographicSize;
    }

    void Update() {

        if (isGoal) {
            Vector3 targetPos = new Vector3(0, 0, -10);
            mainCamera.transform.position = Vector3.SmoothDamp(mainCamera.transform.position, targetPos, ref velocity, smoothTime);
            cameraSize = Mathf.SmoothDamp(cameraSize, overCameraSize, ref cameraSizeVelocity, smoothTime);
            cameraComponent.orthographicSize = cameraSize;
        }
    }

    public void Goal() {
        isGoal = true;
        cameraFollow.enabled = false;
        Invoke("ShowClearPanel", smoothTime + 3);
    }

    void ShowClearPanel() {
        stageController.ShowClearPanel();
    }

}
