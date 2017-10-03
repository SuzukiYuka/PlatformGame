using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

    public Player player;
    public Text coinLabel;

    AudioSource audioSource;

    private void Start() {

        audioSource = player.GetComponent<AudioSource>();
    }

    public void GetCoin() {
        audioSource.PlayOneShot(audioSource.clip);
        player.coinCount++;
        coinLabel.text = "コイン×" + player.coinCount.ToString();
    }
}
