using UnityEngine;

public class BoxHold : MonoBehaviour
{
    private bool hold = false;
    [SerializeField] private float distance = 4f;
    [SerializeField] private Transform holdPoint;

    private ITakeble pickedUpBox;

    private void Update()
    {
        PickUpBox();
    }

    private void PickUpBox()
    {
        if (Input.GetKeyDown(KeyCode.F) == false)
            return;

        if (hold == false)
        {
            ITakeble box = FindNearValidateBox();
            HoldBox(box);
        }
        else
        {
            DropBox(pickedUpBox);
        }
    }

    private ITakeble FindNearValidateBox()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, distance);

        ITakeble box = hit.collider.GetComponent<ITakeble>();
        if (box == null)
            return null;

        return box;
    }

    private void HoldBox(ITakeble box)
    {
        if (box == null) 
            return;

        box.PickUp(holdPoint);

        hold = true;
        pickedUpBox = box;
    }

    private void DropBox(ITakeble box)
    {
        if (box == null)
            return;

        box.Drop(holdPoint);

        hold = false;
        pickedUpBox = null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * transform.localScale.x * distance);
    }
}
