using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class SceneChangeManager : MonoBehaviour
{
    public static SceneChangeManager Instacnce { get => _instance; }
    private static SceneChangeManager _instance;

    private void Awake()
    {
        _instance ??= this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public async void ChangeScene(int index)
    {
        await SceneManager.LoadSceneAsync(index);
    }

    public async void ChangeScene(string sceneName)
    {
        await SceneManager.LoadSceneAsync(sceneName);
    }
}
