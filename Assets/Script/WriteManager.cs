using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteManager : MonoBehaviour
{
    public static WriteManager instance;

    private int test;
    private int level;

    public GameObject[] ansArray; //存放"Ans"Array

    void Start()
    {
        // test = 0;
        // GameManager.Instance.Test = test;
        level = GameManager.Instance.Level;
        test = GameManager.Instance.Test;
        Debug.Log("WriteMangaer_level" + level);//got it
        Debug.Log("WriteMangaer_test" + test);//got it

        ansArray = GameObject.FindGameObjectsWithTag("GameObject");
        Debug.Log("WriteMangaer_Number of cubes found: " + ansArray.Length); //cube array 3
        foreach (var cube in ansArray)
        {
            Debug.Log("Write Cube name: " + cube.name);
        }

        checkLevel();

    }

    private void Awake()
    {
        instance = this;
    }

    public void checkLevel()
    {
        switch (level)
        {
            case 1:
                Debug.Log("WriteMangaer_checkLevel");
                SetWriteLevelQuestion1();
                break;
            case 2:
                Debug.Log("WriteMangaer_checkLevel 2");
                SetWriteLevelQuestion2();
                break;
            case 3:
                SetWriteLevelQuestion3();
                break;
        }
    }

    public void SetWriteLevelQuestion1()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetWriteLevelQuestion1");
                Write.instance.SetWriteQuestion1();

                break;
            case 1:
                Debug.Log("SetWriteLevelQuestion2");
                Write.instance.SetWriteQuestion2();
                break;
            case 2:
                Debug.Log("SeWriteLevelQuestion3");
                Write.instance.SetWriteQuestion3();
                break;
        }
    }

    public void SetWriteLevelQuestion2()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetWriteLevelQuestion4");
                Write.instance.SetWriteQuestion4();

                break;
            case 1:
                Debug.Log("SeWriteLevelQuestion5");
                Write.instance.SetWriteQuestion5();
                break;
            case 2:
                Debug.Log("SetWriteLevelQuestion6");
                Write.instance.SetWriteQuestion6();
                break;
        }
    }

    public void SetWriteLevelQuestion3()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetWriteLevelQuestion7");
                Write.instance.SetWriteQuestion7();

                break;
            case 1:
                Debug.Log("SetWriteLevelQuestion8");
                Write.instance.SetWriteQuestion8();
                break;
            case 2:
                Debug.Log("SetWriteLevelQuestion9");
                Write.instance.SetWriteQuestion9();
                break;
        }
    }

    void Update()
    {
        // checkLevel(); //不要放在update

    }
}
