using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    public Text enemyCountLabel;
    int enemyCount = 0;

    void Awake() {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyCountLabel.text = "敵 × " + enemyCount.ToString();
    }

    public void AttackEnemy() {
        enemyCount -= 1;
        enemyCountLabel.text = "敵 × " + enemyCount.ToString();
    }

}
