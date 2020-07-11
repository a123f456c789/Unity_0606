
using UnityEngine;
using UnityEngine.SceneManagement;

 public class scenecontrol : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("遊戲1");

    }
    public void DelayLoadScene()
    {
        Invoke("LoadScene", 0.9F);
    }
    public void DelayQuit()
    {
        Invoke("Quit", 0.5F);
    }
}
