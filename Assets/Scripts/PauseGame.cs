using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool _gameIsPause = false;

    [SerializeField] GameObject _pauseMenuUI;

    private void Start()
    {
        Pause();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
                
            }
        }
        
    }
    public void Resume() 
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPause = false;
    }
    public void Pause()
    {
    _pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _gameIsPause = true;
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
