using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject _tpPoint;
    private void OnTriggerStay(Collider other)
    {
        other.transform.position = _tpPoint.transform.position;
    }
}
