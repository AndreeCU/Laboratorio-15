using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControll : MonoBehaviour
{
    [Header("Prefab Variables")]
    public GameObject enemyPrefab;
    [Header("Position Variables")]
    public float minXPosition;
    public float maxXPosition;
    [Header("Time Variables")]
    public float minTimeToCreate;
    public float maxTimeToCreate;
    private float timeToCreateEnemy;
    private float currentTimeToCreate;
    [Header("Game Manager Variables")]
    public GameManangerControl gameManager;

    // Start is called before the first frame update
    void Start()
    {
        timeToCreateEnemy = Random.Range(minTimeToCreate, maxTimeToCreate);
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeToCreate = currentTimeToCreate + Time.deltaTime;
        if(currentTimeToCreate >= timeToCreateEnemy)
        {
            Vector2 positionToCreate = new Vector2(Random.Range(minXPosition, maxXPosition), 4.5f);
            GameObject enemy = Instantiate(enemyPrefab, positionToCreate, transform.rotation);
            enemy.GetComponent<Enemy>().SetGameMananger(gameManager);
            timeToCreateEnemy = Random.Range(minTimeToCreate, maxTimeToCreate);
            currentTimeToCreate = 0;
        }
    }

  
}
