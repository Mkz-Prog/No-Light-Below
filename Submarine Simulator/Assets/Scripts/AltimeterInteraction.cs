using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltimeterIntaraction : InteractableObject
{
    [SerializeField] private GameObject gameObject;
    [SerializeField] private float rotateSpeed = 100f;
    public override void Interact()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }
}