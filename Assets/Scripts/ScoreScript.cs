using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    private int count;

    [SerializeField]
    private Text score;
    [SerializeField]
    private GameObject winText;
    [SerializeField]
    private GameObject winButton;

    void Start()
    {
        count = 0;
        updateText();
    }



    private void updateText()
    {
        score.text = count.ToString();
        if ( count >= 13)
        {
            winText.SetActive(true);
            winButton.SetActive(true);
        }
    }

    public void Count(int x)
    {
        count += x;
        updateText();
    }



}
