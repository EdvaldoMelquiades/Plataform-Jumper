using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_height : MonoBehaviour {

    public Transform character;
    Text score_text;

    // Start is called before the first frame update
    void Start () {

        score_text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {

        score_text.text = Mathf.RoundToInt(character.position.y).ToString();

    }
}
