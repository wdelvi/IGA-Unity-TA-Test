using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string textToWrite = "Hello World!";

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(textToWrite + Sum(5,10));
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public int Sum(int numberOne, int numberTwo)
    {
        return numberOne + numberTwo;
    }
}
