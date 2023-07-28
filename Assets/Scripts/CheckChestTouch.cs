using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChestTouch : MonoBehaviour
{
    private Camera _mainCamera;
    private ChestInteractor _chest;

    private void Awake()
    {
        _mainCamera = Camera.main;
        _chest = GetComponent<ChestInteractor>();
    }

    private void Update()
    {
        Vector3 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);
        RaycastHit2D hitInfo = Physics2D.Raycast(mousePosition2D, Vector2.zero);
        
        
        if (hitInfo.collider.CompareTag("Chest"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                _chest.InteractWithChest(true);
            }
        }
        else
        {
            _chest.InteractWithChest(false);
        }
    }
    
}