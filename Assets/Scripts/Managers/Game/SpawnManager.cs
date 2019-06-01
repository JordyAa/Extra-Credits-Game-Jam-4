#pragma warning disable 0649
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [Header("Hittable")]
    [SerializeField] private float timeBetweenSpawns = 1f;
    [SerializeField] private float timeUntilSpawn = 1f;

    [SerializeField] private GameObject hittablePrefab;
    
    [Header("Rocket")]
    [SerializeField] private float timeBetweenRockets = 1f;
    [SerializeField] private float timeUntilRocket = 1f;
    
    [SerializeField] private GameObject rocketPrefab;
    [SerializeField] private GameObject warnPrefab;
    
    private float xSpawn;
    private float ySpawn;

    private void Start()
    {
        Camera cam = Camera.main;
        if (cam != null)
        {
            ySpawn = 0.85f * cam.orthographicSize;
            xSpawn = ySpawn * cam.aspect + 5f;
        }
    }

    private void Update()
    {
        if (GameOverManager.instance.gameOver) return;
        
        if (timeUntilSpawn > 0)
        {
            timeUntilSpawn -= Time.deltaTime;
        }
        else
        {
            timeUntilSpawn = Random.Range(0.9f * timeBetweenSpawns, 1.1f * timeBetweenSpawns);
            timeBetweenSpawns *= Random.Range(0.99f, 1f);
            SpawnBox();
        }
        
        if (timeUntilRocket > 0)
        {
            timeUntilRocket -= Time.deltaTime;
        }
        else
        {
            timeUntilRocket = Random.Range(0.9f * timeBetweenRockets, 1.1f * timeBetweenRockets);
            timeBetweenSpawns *= Random.Range(0.95f, 1f);
            SpawnRocket();
        }
    }

    private void SpawnBox()
    {
        GameObject go = Instantiate(hittablePrefab,
            new Vector3(xSpawn, Random.Range(-ySpawn, ySpawn), 0f),
            Quaternion.identity);

        go.GetComponent<HittableText>().textBox = new TextBox(Random.Range(0f, 1f) > 0.5f);

        PlayerManager.instance.AddToFearSetter(go);
    }

    private void SpawnRocket()
    {
        float x = -1.5f * xSpawn;
        float y = Random.Range(-ySpawn, ySpawn);
        
        GameObject rocket = Instantiate(rocketPrefab,
            new Vector3(x, y, 0f),
            Quaternion.identity);

        GameObject warn = Instantiate(warnPrefab,
            new Vector3(x, y, 0f),
            Quaternion.identity);

        warn.GetComponent<RocketWarn>().target = rocket.transform;
    }
}
