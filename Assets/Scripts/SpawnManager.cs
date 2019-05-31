#pragma warning disable 0649
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float timeBetweenSpawns = 1f;
    private float timeUntilSpawn;

    [SerializeField] private GameObject hittablePrefab;
    
    private float xSpawn;
    private float ySpawn;

    private void Start()
    {
        Camera cam = Camera.main;
        if (cam != null)
        {
            ySpawn = cam.orthographicSize;
            xSpawn = ySpawn * cam.aspect + 5f;
        }
    }

    private void Update()
    {
        if (timeUntilSpawn > 0)
        {
            timeUntilSpawn -= Time.deltaTime;
        }
        else
        {
            timeUntilSpawn = Random.Range(0.9f * timeBetweenSpawns, 1.1f * timeBetweenSpawns);

            SpawnBox();
        }
    }

    private void SpawnBox()
    {
        GameObject go = Instantiate(hittablePrefab,
            new Vector3(xSpawn, Random.Range(-ySpawn, ySpawn), 0f),
            Quaternion.identity);

        TextBox[] pool = Resources.LoadAll<TextBox>("Text_Boxes");
        go.GetComponent<Hittable>().textBox = pool[Random.Range(0, pool.Length)];
            
        PlayerManager.instance.AddToFearSetter(go);
    }
}
