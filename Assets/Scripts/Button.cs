using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private ButtonsDoor buttonsdoor; 
    private bool buttonDown;
    private void Update()
    {
        if (buttonDown == true)
        {
            buttonsdoor.Open();
        }
        else if (buttonDown == false) 
        {
            buttonsdoor.Close();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        buttonDown = true;
    }
    private void OnTriggerExit()
    {
        buttonDown = false;
    }
}
