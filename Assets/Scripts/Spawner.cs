using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Slime;
    [SerializeField]
    private GameObject ToxicFrog;
    [SerializeField]
    private GameObject Boss;

    [SerializeField]
    private float ToxicFrogInterval = 3.5f;
    [SerializeField]
    private float SlimeInterval = 10f;
    [SerializeField]
    private float BossInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(SlimeInterval, Slime));
        StartCoroutine(spawnEnemy(ToxicFrogInterval, ToxicFrog));
        StartCoroutine(spawnEnemy(BossInterval, Boss));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
