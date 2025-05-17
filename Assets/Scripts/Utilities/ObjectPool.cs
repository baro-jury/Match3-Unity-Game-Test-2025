using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject[] prefabs;
    private Queue<GameObject> pool = new Queue<GameObject>();

    public GameObject GetObject(int index)
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }

        return Instantiate(prefabs[index], transform);
    }

    public void ReleaseToPool(GameObject obj)
    {
        obj.transform.SetParent(this.transform);
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
