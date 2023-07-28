using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class ChestInteractor : MonoBehaviour
    {
       
        public Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void InteractWithChest(bool value)
        {
            animator.SetBool("IsOpened", value);
        }
    }

