using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EnemyController : MonoBehaviour {

    public Text enemyCountLabel;
    public GameObject panel;
    [HideInInspector]
    public int enemyCount = 0;
    public StageController stageController;
    [HideInInspector]
    public bool isGameOver;
    public PlayerInput playerInput;

    void Awake() {
        panel.transform.DOMoveX(700, 1);
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyCountLabel.text = "あと" + enemyCount.ToString() + "体";
    }

    public void AttackEnemy() {
        enemyCount -= 1;
        if (enemyCount == 0) {
            enemyCountLabel.text = "GOOD JOB!";
        } else {
            enemyCountLabel.text = "あと" + enemyCount.ToString() + "体";
        }
        panel.transform.DOMoveX(550, 1).SetEase(Ease.InOutSine);
        Invoke("hide", 2);

    }

    public void gameOver() {
        isGameOver = true;
        stageController.gameOverPanel.transform.DOScale(new Vector3(1, 1, 1), 1);
        playerInput.canInput = false;
    }

    void hide() {
        panel.transform.DOMoveX(700, 1).SetEase(Ease.InSine);
    }

}
