using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevelButton : MonoBehaviour
{
    [SerializeField] private GameObject nextLevelButton;
    
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        Vector3 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);
        RaycastHit2D hitInfo = Physics2D.Raycast(mousePosition2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0) && hitInfo.collider.CompareTag("NextLevel"))
        {
            nextLevelButton.SetActive(true);
        }
    }
}