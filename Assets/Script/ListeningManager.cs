using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeningManager : MonoBehaviour
{
    public static ListeningManager instance;
 
    private int test;
    private int level;

    // Start is called before the first frame update
    void Start()
    {
        test= GameManager.Instance.Test;
        level= GameManager.Instance.Level;
        Debug.Log("ListeningManager level" + level);//got it
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
                Debug.Log("tListening_checkLevel");
                SetListeningLevelQuestion1(); 
                break;
            case 2:
                Debug.Log("Listening_checkLevel 2");
                SetListeningLevelQuestion2();
                break;
            case 3:
                SetListeningLevelQuestion3();
                break;
        }
    }

    public void SetListeningLevelQuestion1()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetListeningLevelQuestion1");
                Listening_1.instance.SetListeningQuestion1();
           
                break;
            case 1:
                Debug.Log("SetListeningLevelQuestion2");
                Listening_1.instance.SetListeningQuestion2();
                break;
            case 2:
                Debug.Log("SetListeningLevelQuestion3");
                Listening_1.instance.SetListeningQuestion3();
                break;
        }
    }

    public void SetListeningLevelQuestion2()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetListeningLevelQuestion4");
                Listening_1.instance.SetListeningQuestion4();

                break;
            case 1:
                Debug.Log("SetListeningLevelQuestion5");
                Listening_1.instance.SetListeningQuestion5();
                break;
            case 2:
                Debug.Log("SetListeningLevelQuestion6");
                Listening_1.instance.SetListeningQuestion6();
                break;
        }
    }

    public void SetListeningLevelQuestion3()
    {
        switch (test)
        {
            case 0:
                Debug.Log("SetListeningLevelQuestion7");
                Listening_1.instance.SetListeningQuestion7();

                break;
            case 1:
                Debug.Log("SetListeningLevelQuestion8");
                Listening_1.instance.SetListeningQuestion8();
                break;
            case 2:
                Debug.Log("SetListeningLevelQuestion9");
                Listening_1.instance.SetListeningQuestion9();
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
      // checkLevel(); //不要放在update

    }
}
