using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadManager : MonoBehaviour
{
    public static ReadManager instance;

    private int test;
    private int level;

    public GameObject[] ansArray; //存放"Ans"Array

    void Start()
    {
        level = GameManager.Instance.Level;
        test=GameManager.Instance.Test;

        Debug.Log("ReadMangaer_level" + level);//got it
        Debug.Log("ReadMangaer_test" + test);//got it

        ansArray = GameObject.FindGameObjectsWithTag("GameObject");
        Debug.Log("ReadMangaer_Number of cubes found: " + ansArray.Length); //cube array 3
        foreach (var cube in ansArray)
        {
            Debug.Log("Cube name: " + cube.name);
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
                Debug.Log("ReadMangaer_checkLevel");
                SetReadingLevelQuestion1();
                break;
            case 2:
                Debug.Log("ReadMangaer_checkLevel 2");
                SetReadingLevelQuestion2();
                break;
            case 3:
                SetReadingLevelQuestion3();
                break;
        }
    }

    public void SetReadingLevelQuestion1()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetReadingLevelQuestion1");
                Reading.instance.SetReadingQuestion1();

                break;
            case 1:
                Debug.Log("SetReadingLevelQuestion2");
                Reading.instance.SetReadingQuestion2();
                break;
            case 2:
                Debug.Log("SeReadingLevelQuestion3");
                Reading.instance.SetReadingQuestion3();
                break;
        }
    }

    public void SetReadingLevelQuestion2()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetReadingLevelQuestion 4");
                Reading.instance.SetReadingQuestion4();

                break;
            case 1:
                Debug.Log("SetReadingLevelQuestion 5");
                Reading.instance.SetReadingQuestion5();
                break;
            case 2:
                Debug.Log("SetReadingLevelQuestion 6");
                Reading.instance.SetReadingQuestion6();
                break;
        }
    }

    public void SetReadingLevelQuestion3()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetListeningLevelQuestion7");
                Reading.instance.SetReadingQuestion7();

                break;
            case 1:
                Debug.Log("SetListeningLevelQuestion8");
                Reading.instance.SetReadingQuestion8();
                break;
            case 2:
                Debug.Log("SetListeningLevelQuestion9");
                Reading.instance.SetReadingQuestion9();
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        // checkLevel(); //不要放在update

    }
}
