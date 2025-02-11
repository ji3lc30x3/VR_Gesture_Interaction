using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listening_1 : MonoBehaviour
{
    public static Listening_1 instance;

    [SerializeField]
    public Material[] arCubeMaterial;

    private Renderer cubeRenderer;

    public GameObject[] cubeArray; //存放"Ans"Array
    
    private List<string> ans = new List<string>();

    void Start()
    {
        cubeArray = GameObject.FindGameObjectsWithTag("GameObject");
    }

    public void SetListeningQuestion1()
    {
        Debug.Log("SetListeningQuestion1");

        List<string> correctAns = new List<string>() { "3", "1", "2" };
        GameManager.Instance.correctAnswer.Clear();

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        if (cubeArray.Length != 0)
        {
            for (int i = 0; i < cubeArray.Length; i++)
            {
                cubeArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[i]; 
            }
        }

    }

    public void SetListeningQuestion2()
    {
        Debug.Log("SetListeningQuestion2");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2", "3", "1" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        if (cubeArray.Length != 0)
        {
            for (int i = 0; i < cubeArray.Length; i++)
            {
                int x = 3 + i;
                cubeArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];

            }
        }
    }

    public void SetListeningQuestion3()
    {
        Debug.Log("SetListeningQuestion3");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2", "1", "3" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        if (cubeArray.Length != 0)
        {
            for (int i = 0; i < cubeArray.Length; i++)
            {
                int x = 6 + i;
                cubeArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];

            }
        }
    }

    public void SetListeningQuestion4()
    {
        Debug.Log("SetListeningQuestion 4");
        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "1", "3", "2" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        cubeArray[0].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[1];
        cubeArray[1].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[14];
        cubeArray[2].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[10];
            
    }

    public void SetListeningQuestion5()
    {
        Debug.Log("SetListeningQuestion 5");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2", "3", "1" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        cubeArray[0].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[1];
        cubeArray[1].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[10];
        cubeArray[2].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[2];
    }

    public void SetListeningQuestion6()
    {
        Debug.Log("SetListeningQuestion 6");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "3", "2", "1" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        cubeArray[0].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[12];
        cubeArray[1].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[11];
        cubeArray[2].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[4];
    }

    public void SetListeningQuestion7()
    {
        Debug.Log("SetListeningQuestion 7");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2", "3", "1" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        cubeArray[0].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[0];
        cubeArray[1].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[10];
        cubeArray[2].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[2];


    }

    public void SetListeningQuestion8()
    {
        Debug.Log("SetListeningQuestion 8");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "3", "1", "2" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        cubeArray[0].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[2];
        cubeArray[1].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[0];
        cubeArray[2].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[9];
    }

    public void SetListeningQuestion9()
    {
        Debug.Log("SetListeningQuestion9");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2", "1", "3" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material
        cubeArray[0].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[2];
        cubeArray[1].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[15];
        cubeArray[2].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[1];
    }

    private void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }
}
