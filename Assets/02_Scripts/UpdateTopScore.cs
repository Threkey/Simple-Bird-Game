using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateTopScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Top Score: " + PlayerPrefs.GetInt("TopScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
