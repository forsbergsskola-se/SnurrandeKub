using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text label;

    // Update is called once per frame
    void Start()
    {
        var controller = FindObjectOfType<Crapper>();
        controller.ScoreChange.AddListener(OnScoreChanged);
        OnScoreChanged(controller.score);
    }
}
