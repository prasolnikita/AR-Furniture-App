using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectRotation : MonoBehaviour
{
    public GameObject container;
    public float rotationSpeed = 100f;

    public void RotateActiveObject(int direction)
    {
        GameObject activeObject = GetActiveObject();
        if (activeObject != null)
        {
            activeObject.transform.Rotate(Vector3.up, direction * rotationSpeed * Time.deltaTime);
        }
    }

    private GameObject GetActiveObject()
    {
        foreach (Transform child in container.transform)
        {
            if (child.gameObject.activeSelf)
                return child.gameObject;
        }

        return null;
    }
}
