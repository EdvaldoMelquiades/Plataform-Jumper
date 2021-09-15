using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_over : MonoBehaviour {

	public Transform character;
	int alto = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (character.position.y > 5) {

			alto = 1;

		}

		if (alto == 1) {

			SceneManager.LoadScene ("End", LoadSceneMode.Single);

		}

	}

}
