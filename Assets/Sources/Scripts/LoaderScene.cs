using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour 
{
    public void Load(int indexScene) => SceneManager.LoadScene(indexScene);
}
