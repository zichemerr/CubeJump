using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    public void Load(int indexScene) => SceneManager.LoadScene(indexScene);

    public void Restart()
    {
        int indexActiveScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexActiveScene);
    }
}