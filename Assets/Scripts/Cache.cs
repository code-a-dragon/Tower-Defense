using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Cache will be used to store information that needs to be used by multiple objects and
//will be implemented as a singleton

public class Cache : MonoBehaviour
{

    public  Text scoreText;
    private static Text cacheScoreText;

    private Cache cache;
    private static int score = 0;

    void Start()
    {
        Cache.cacheScoreText = scoreText;
    }

    private void Awake()
    {
        if (cache == null)
        {
            cache = this;
        }
        else
        {
            Debug.Log("Second instance of Cache");
        }
    }

    public Cache getCache()
    {
        return cache;
    }

    public static int getScore()
    {
        return Cache.score;
    }
    public static void incrementScore(int amount)
    {
        Cache.score += amount;
        Cache.cacheScoreText.text = Cache.score.ToString();
    }
    public static void resetScore()
    {
        Cache.score = 0;
    }
}
