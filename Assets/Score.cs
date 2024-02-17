using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text playerScore;
    int points;

    public int Points
    {
        get { return points; }
        set { points = value; playerScore.text = Points.ToString(); }
    }



    // Start is called before the first frame update
    void Start()
    {
        playerScore = FindObjectOfType<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
