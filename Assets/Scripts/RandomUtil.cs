using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomUtil
{
    public static void PrintHelloWorld()
    {
        Debug.Log("Hello World");
    }


    public static T RandomUtilM<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
