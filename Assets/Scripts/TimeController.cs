using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour {

    public Text timeLabel;
    float time;

    void Update() {

        time += Time.deltaTime;
        timeLabel.text = "Time: " + time.ToString("F2");
    }
}
