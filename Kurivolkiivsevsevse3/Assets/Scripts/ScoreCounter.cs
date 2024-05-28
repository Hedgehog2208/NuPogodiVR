using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreCounter : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI textMeshProUGUI;
    private float timeSpawn;
    private EggSpawner eggSpawner;
    private Egg egg;
    public void AddScore(int scoreValue)
    {
        score += scoreValue;
        if (score <= 0)
        {
            score = 0;
        }

        textMeshProUGUI.text = score.ToString();
        Delete();
        eggSpawner.SetTimer(score);
	}

    public void Delete()
    {
		egg.DestroyObj();
	}

    public void SetEgg(Egg egg)
    {
        this.egg = egg;
    }
}
