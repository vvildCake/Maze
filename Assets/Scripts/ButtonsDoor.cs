using UnityEngine;

public class ButtonsDoor : MonoBehaviour
{
    [SerializeField] private float SpeedOpenButtonsDoor = -1f;
    public void Open()
    {
        float _openY = Mathf.Clamp(transform.position.y + SpeedOpenButtonsDoor * Time.deltaTime, -0.64f, 0.5f);
        transform.position = new Vector3(transform.position.x, _openY , transform.position.z);
    }
    public void Close()
    {
        float _closeY = Mathf.Clamp(transform.position.y + -SpeedOpenButtonsDoor * Time.deltaTime, -0.64f, 0.5f);
        transform.position = new Vector3(transform.position.x, _closeY , transform.position.z);
    }
}
