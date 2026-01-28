using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour {
    public static Locator Instance { get; private set; }
    public W4Pigeon Plaeyer { get; private set; }

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this.gameObject);
            return;
        }

            Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj != null)
        {
            Plaeyer = playerObj.GetComponent<W4Pigeon>();
        }
    }

}
