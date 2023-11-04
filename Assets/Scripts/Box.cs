using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Box : MonoBehaviour, ITakeble
{
    [SerializeField] private Transform _interactableObjects;

    public void Drop(Transform dropPosition)
    {
        gameObject.transform.SetParent(_interactableObjects);
        gameObject.transform.position = dropPosition.position;
    }

    public void PickUp(Transform holdPos)
    {
        gameObject.transform.SetParent(holdPos);
        gameObject.transform.position = holdPos.position;
    }
}
