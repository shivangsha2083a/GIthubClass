using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    private float speed = 10f;
    private float lifetime = 3f;
    private float timer;

    private IObjectPool<Bullet> pool;

    public void SetPool(IObjectPool<Bullet> pool)
    {
        this.pool = pool;
    }

    private void OnEnable()
    {
        timer = 0f;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            pool.Release(this);
        }
    }
}