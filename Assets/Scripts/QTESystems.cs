using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTESystems : MonoBehaviour
{
    public GameObject DisplayBox;
    public GameObject PassBox;
    public int QTEGen;
    public int WaitForKey;
    public int CorrectKey;
    public int CountingDown;

    void Update()
    {

        if (WaitForKey == 0)
        {
            QTEGen = Random.Range(1, 4);
            CountingDown = 1;
            StartCoroutine(CountDown());
            if (QTEGen == 1)
            {
                WaitForKey = 1;
                DisplayBox.GetComponent<Text>().text = "[E]";
            }
            if (QTEGen == 2)
            {
                WaitForKey = 2;
                DisplayBox.GetComponent<Text>().text = "[R]";
            }
            if (QTEGen == 3)
            {
                WaitForKey = 3;
                DisplayBox.GetComponent<Text>().text = "[T]";
            }
        }
        if (QTEGen == 1)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("您按下了“E”");
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
        if (QTEGen == 2)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {

                    Debug.Log("您按下了“R”");
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
        if (QTEGen == 3)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    Debug.Log("您按下了“T”");
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }

    }

    IEnumerator KeyPressing()
    {
        QTEGen = 4;
        if (CorrectKey == 1)
        {
            CountingDown = 2;
            PassBox.GetComponent<Text>().text = "ATTACK !!!!";

            yield return new WaitForSeconds(0.2f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            WaitForKey = 0;
            CountingDown = 1;

        }
        if (CorrectKey == 2)
        {
            CountingDown = 2;
            PassBox.GetComponent<Text>().text = "FAIL !!!!";
            Debug.Log("您按錯了”");
            yield return new WaitForSeconds(0.5f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            WaitForKey = 0;
            CountingDown = 1;

        }


    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3.5f);
        if (CountingDown == 1)
        {
            QTEGen = 4;
            CountingDown = 2;
            PassBox.GetComponent<Text>().text = "TOO LATE !!!!";
            Debug.Log("您按太慢了”");
            yield return new WaitForSeconds(3f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            WaitForKey = 0;
            CountingDown = 1;


        }
    }




}
