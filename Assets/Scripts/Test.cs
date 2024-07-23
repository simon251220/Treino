using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject cube;

    
   public void PrintHello()
    {
        Debug.Log("Hello");
    }
    public void  CreateCube()
    {
        Instantiate(cube, transform);
    }

    [UnityEditor.MenuItem("Cube/inst")]
    public static void InstCube()
    {
        Test test = GameObject.Find("Test").GetComponent<Test>();
        test.CreateCube();
    }


}
