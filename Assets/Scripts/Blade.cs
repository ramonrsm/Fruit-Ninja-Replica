using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

    [SerializeField]
    Rigidbody2D mRigidbody2D;

    [SerializeField]
    bool isCutting = false;

    [SerializeField]
    GameObject bladeTrailPrefab;

    void Start() {
        mainCamera   = Camera.main;
        mRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isCutting = Input.GetMouseButton(0);
        
        if (isCutting) {
            UpdateCut();
        }
    }

    private void UpdateCut() {
        mRigidbody2D.position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
