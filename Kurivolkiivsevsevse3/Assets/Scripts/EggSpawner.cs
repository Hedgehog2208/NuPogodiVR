using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EggSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] positions;
    [SerializeField] private float timeSpawn;
    [SerializeField] private Egg [] prefab;
    [SerializeField] private ScoreCounter scoreCounter;
    private Egg spawnObj;

    private float timer;
    private float firstTime;

    void Start()
    {
		timer = timeSpawn;
        firstTime = timeSpawn;
	}

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    private void Timer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spawnObj = Instantiate(prefab[Random.Range(0,prefab.Length)], positions[Random.Range(0, positions.Length)].position, Quaternion.identity);
            timer = timeSpawn;
            spawnObj.SetScore(scoreCounter);
            scoreCounter.SetEgg(spawnObj);
        }
    }
    public void SetTimer(int score)
    {
		if (score == 9)
		{
			timeSpawn = firstTime;
		}

		if (score == 10 || score == 19)
		{
			timeSpawn = firstTime-1;
		}

		if (score == 20 || score == 29)
		{
			timeSpawn = firstTime - 2;

		}

		if (score == 30)
		{
			timeSpawn = firstTime - 3;

		}
	}
}
