using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageController : MonoBehaviour {

    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject clearPanel;

    [HideInInspector]
    public bool isPause = false;
    [HideInInspector]
    public bool isGameOver = false;

    public Button resumeButton;
    public Button exitButton;
    public Button retryButton;

    public Controller2D controller;

    public PlayerInput playerInput;

    public EnemyController enemyController;

    void Start() {
        pausePanel.transform.localScale = Vector3.zero;
        gameOverPanel.transform.localScale = Vector3.zero;
        clearPanel.transform.localScale = Vector3.zero;
        resumeButton.onClick.AddListener(pause);
        retryButton.onClick.AddListener(retry);
        exitButton.onClick.AddListener(exit);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            pause();
        }
    }

    void exit() {
        SceneManager.LoadSceneAsync("StageSelect");
    }

    void retry() {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

    void pause() {

        isPause = !isPause;
        isGameOver = enemyController.isGameOver;
        playerInput.canInput = !isPause && !isGameOver;
        if (!isGameOver) {
            if (isPause) {
                pausePanel.transform.DOScale(new Vector3(1, 1, 1), 0.4f).SetEase(Ease.InSine);
            } else {
                pausePanel.transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InSine);
            }
        }
    }

    public void ShowClearPanel() {
        clearPanel.transform.DOScale(new Vector3(1, 1, 1), 0.2f).SetEase(Ease.InSine);
    }

}
