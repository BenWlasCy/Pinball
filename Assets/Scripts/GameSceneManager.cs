using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void LoadMainMenu() => SceneManager.LoadScene(0);

    public void LoadGameScene() => SceneManager.LoadScene(1);

    //public void LoadLevelTwo() => SceneManager.LoadScene(2);
}
