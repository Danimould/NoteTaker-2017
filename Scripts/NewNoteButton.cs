﻿using UnityEngine.UI;
using UnityEngine;

public class NewNoteButton : MonoBehaviour {

	public string scene;
    private WorldController wc;

	void Awake () {
        wc = FindObjectOfType<WorldController>();
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ButtonPressed);
	}

    private void ButtonPressed() {
        wc.SetScene(scene);
    }
}
