using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    public Text enemyCountLabel;
    int enemyCount = 0;
    public StageController stageController;
    [HideInInspector]
    public bool isGameOver;
    public PlayerInput playerInput;

    void Awake() {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyCountLabel.text = "敵 × " + enemyCount.ToString();
    }

    public void AttackEnemy() {
        enemyCount -= 1;
        enemyCountLabel.text = "敵 × " + enemyCount.ToString();
    }

    public void gameOver() {
        isGameOver = true;
        stageController.gameOverPanel.transform.DOScale(new Vector3(1, 1, 1), 1);
        playerInput.canInput = false;
    }

}
