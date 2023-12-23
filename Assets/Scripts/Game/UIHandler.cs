using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int _xp = 0;

    public void Start()
    {
        SetScore(0);
    }
    public void SetScore(int xp) 
    {
        scoreText.text = $"score: {_xp += xp}";    
    }
}
