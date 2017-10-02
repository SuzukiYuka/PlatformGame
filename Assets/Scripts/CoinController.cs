using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

    public Player player;
    public Text coinLabel;

    public void GetCoin() {
        player.coinCount++;
        coinLabel.text = "コイン×" + player.coinCount.ToString();
    }
}
