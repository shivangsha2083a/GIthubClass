using UnityEngine;
using UnityEngine.Pool;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private Bullet prefab;
    [SerializeField] private float spawnInterval = 0.3f;

    private IObjectPool<Bullet> pool;

    private void Awake()
    {
        pool = new ObjectPool<Bullet>(
            createFunc: () => Instantiate(prefab),
            actionOnGet: (obj) => obj.gameObject.SetActive(true),
            actionOnRelease: (obj) => obj.gameObject.SetActive(false),
            actionOnDestroy: (obj) => Destroy(obj.gameObject),
            collectionCheck: true,
            defaultCapacity: 10,
            maxSize: 20
        );
    }

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void Spawn()
    {
        Bullet bullet = pool.Get();

        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;

        bullet.SetPool(pool);
    }

    public void ReturnToPool(Bullet bullet)
    {
        pool.Release(bullet);
    }
}