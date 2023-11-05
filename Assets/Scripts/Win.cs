using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void FirstLvl()
    {
        SceneManager.LoadScene(0);
    }
    public void SecondLvl()
    {
        SceneManager.LoadScene(1);
    }
    public void ThirdLvl()
    {
        SceneManager.LoadScene(2);
    }
    public void FourthLvl()
    {
        SceneManager.LoadScene(3);
    }
    public void FifthLvl()
    {
        SceneManager.LoadScene(4);
    }
}
