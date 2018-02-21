using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    private float offset = 4790;
    public void Update()
    {
        float playerPos = player.position.z + offset;
        scoreText.text = playerPos.ToString("0");
    }
}
