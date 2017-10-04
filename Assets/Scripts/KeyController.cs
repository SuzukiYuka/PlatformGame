using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyController : MonoBehaviour {

    public string keyName = "";

    public void LoadStage() {

        SceneManager.LoadScene("Main");
    }


}
