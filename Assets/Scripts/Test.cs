using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Header("Moviment")]
    [SerializeField] private int day = 8;

    [Header("Combat")]
    [SerializeField] float myFloat = 4.5f;
    [SerializeField] bool myBool = true;
    [SerializeField] string myString = "abgkjbvhjgjb";


    public LayerMask mask;


    // Start is called before the first frame update
    void Start()
    {
        myString = LogDay(day);
       
        float sumResult = Sum(day, myFloat);
    }

    // Update is called once per frame
    void Update()
    {

    }

    string LogDay(int dayToLog)
    {
        string messageOftheDay = $"ciao {dayToLog} bla bla bla ";

        Debug.Log("Ciao " + 8 + " bla bla bla");
        Debug.Log(messageOftheDay);

        return messageOftheDay;
    }

    float Sum(float a, float b)
    {

        return a + b;

    }   
        
       
 



}
