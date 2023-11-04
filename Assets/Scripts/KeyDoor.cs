using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.PickUpKeyDoor();
            Destroy(gameObject);
        }
    }
}


