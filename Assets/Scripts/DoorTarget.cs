using UnityEngine;

public class DoorTarget : MonoBehaviour
{
    [SerializeField] private float SpeedOpenDoor = -1f;
    public void OpenTargetDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + SpeedOpenDoor * Time.deltaTime, transform.position.z);
    }
}
