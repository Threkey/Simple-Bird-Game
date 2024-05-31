using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentScore++;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + currentScore.ToString();
    }

    public void SaveTopScore()
    {
        if(currentScore > PlayerPrefs.GetInt("TopScore"))
        {
            PlayerPrefs.SetInt("TopScore", currentScore);
        }
    }
}
