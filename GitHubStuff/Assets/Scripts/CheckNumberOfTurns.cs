using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class CheckNumberOfTurns : MonoBehaviour
{
    public TMP_Text score;
    private int scoreNum;
    public float startRot;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        startRot = transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        angle += 50 * Time.deltaTime;
        if (angle > 180)
        {
            scoreNum++;
            angle -= 180;
        }
        score.text = "Score: " + scoreNum;

    }
}
