using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    public void GameStart() {
        SceneManager.LoadSceneAsync("StageSelect");
    }

    public void Gallery() {
        SceneManager.LoadSceneAsync("StageSelect");
    }

    public void Setting() {
        SceneManager.LoadSceneAsync("StageSelect");
    }
}
