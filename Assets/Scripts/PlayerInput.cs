using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour {
    Player player;
    [HideInInspector]
    public bool canInput;

    void Start() {
        player = GetComponent<Player>();
        canInput = true;
    }
    void Update() {
        Debug.Log(canInput);
        if (canInput) {
            Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            player.SetDirectionalInput(directionalInput);

            if (Input.GetKeyDown(KeyCode.Space)) {
                player.OnJumpInputDown();
            }

            if (Input.GetKeyUp(KeyCode.Space)) {
                player.OnJumpInputUp();
            }
        }
    }

}
