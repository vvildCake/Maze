using UnityEngine;

public class BoxHold : MonoBehaviour
{
    //private bool hold;
    //[SerializeField] private float distance = 4f;
    //RaycastHit2D hit;
    //[SerializeField] private Transform holdPoint;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.F))
    //    {
    //        if (!hold)
    //        {
    //            Physics2D.queriesStartInColliders = false;
    //            hit = Physics2D.Raycast(transform.position, Vector2.left * transform.localScale.x , distance);
    //            if (hit.collider != null)
    //            { 
    //            hold = true;
    //            }
    //        }
    //    }
    //    if (hold) 
    //    {
    //        hit.collider.gameObject.transform.position = holdPoint.position;
    //    }
    //}
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawLine(transform.position, transform.position + Vector3.left * transform.localScale.x * distance);
    //}
}
