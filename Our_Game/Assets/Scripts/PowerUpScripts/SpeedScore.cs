using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedScore : MonoBehaviour
{
    public static float speedscore = 15.0f;
    Text speedtext;

    // Start is called before the first frame update
    void Start()
    {
        speedtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        speedtext.text = "Bullet Speed: " + speedscore;
    }
}
