using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPool<T>
{
    private static readonly Queue<List<T>> pool = new Queue<List<T>>();

    public static List<T> Get()
    {
        return pool.Count > 0 ? pool.Dequeue() : new List<T>();
    }

    public static void Release(List<T> list)
    {
        list.Clear();
        pool.Enqueue(list);
    }

    public static void Clear()
    {
        pool.Clear();
    }
}
