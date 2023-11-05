using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] DoorTarget doorTarget;
    private void OnTriggerEnter(Collider other)
    {
        doorTarget.OpenTargetDoor();
    }
}
