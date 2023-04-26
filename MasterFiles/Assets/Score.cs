using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
	GameObject Player;
	GameObject START;
	public Transform player;
	public Text scoreText;

	// Update is called once per frame
	
	void Update() => scoreText.text = Vector3.Distance(Player.transform.position, START.transform.position).ToString();

    
};
