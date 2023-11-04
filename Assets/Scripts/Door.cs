
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float SpeedOpenDoor = -1f;
    public void DoorIsOpen()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + SpeedOpenDoor * Time.deltaTime, transform.position.z);
    }
}
