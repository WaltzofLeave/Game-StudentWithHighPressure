using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    public int GetScore()
    {
        return score;
    }
    public void SetScore(int score)
    {
        this.score = score;
    }
    public void ClearScore()
    {
        score = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
