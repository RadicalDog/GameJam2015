using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //Properties
    public GameObject winText;

    // Use this for initialization
    void Start () {
        winText = GameObject.Find("WinText");
        winText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll) {
        Text txtWinText = winText.GetComponent<Text>();

        if (coll.gameObject.tag == "Player1")
        {
            //Player2 Wins
            txtWinText.text = "Player 2 Wins";
        }
        else if(coll.gameObject.tag == "Player2")
        {
            //Player1 wins
            txtWinText.text = "Player 1 Wins";
        }
        else
        {
            //Something isn't right
            Debug.Log("An untagged object fell out of the ring");
            Debug.Log(coll.gameObject.name);

            txtWinText.text = "Whoops";
        }

        winText.SetActive(true);
        Time.timeScale = 0;
    }
}
