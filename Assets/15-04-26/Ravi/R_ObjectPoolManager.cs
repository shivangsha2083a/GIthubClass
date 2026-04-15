using System;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class R_ObjectPoolManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int size;

    public ObjectPool<GameObject> objectPool;

    private void Start()
    {
        objectPool = new ObjectPool<GameObject>(CreatePool, GetPooledObject, ReleasePooledObject, DestroyPooledObject, false, 10, 200);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObject = objectPool.Get();
            gameObject.transform.position = Random.insideUnitSphere * 5f;
            StartCoroutine(ReturnAfter(gameObject, 1f));

        }
    }
    private System.Collections.IEnumerator ReturnAfter(GameObject gameObject, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        // Give it back to the pool.
        objectPool.Release(gameObject);
    }
    private GameObject CreatePool()
    {
        return Instantiate(bulletPrefab);
    }

    private void GetPooledObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    private void ReleasePooledObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    private void DestroyPooledObject(GameObject obj)
    {
        Destroy(obj);
    }

    public GameObject GetPooledObject()
    {
        return objectPool.Get();
    }

    public void ReturnPooledObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
