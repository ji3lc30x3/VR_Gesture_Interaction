using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Write : MonoBehaviour
{
    public static Write instance;

    [SerializeField]
    public Material[] arCubeMaterial;
    public Material[] questionMaterial;

    private Renderer cubeRenderer;

    public GameObject[] cubeArray; //存放"Ans"Array
    public GameObject[] questionArray;

    private List<string> ans = new List<string>();

    void Start()
    {
        cubeArray = GameObject.FindGameObjectsWithTag("GameObject");
        questionArray= GameObject.FindGameObjectsWithTag("Question");
    }

    public void SetWriteQuestion1()
    {
        Debug.Log("SetWriteQuestion1");

        List<string> correctAns = new List<string>() { "1", "3", "2" };
        GameManager.Instance.correctAnswer.Clear();

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        //換material 
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[i];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[0];
        }

    }

    public void SetWriteQuestion2()
    {
        Debug.Log("SetWriteQuestion2");

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

        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 3 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
        }

        questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[1];


    }

    public void SetWriteQuestion3()
    {
        Debug.Log("SetWriteQuestion3");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 6 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];              
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[2];
        }

    }

    public void SetWriteQuestion4()
    {
        Debug.Log("SetWriteQuestion4");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 9 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[3];
        }


    }

    public void SetWriteQuestion5()
    {
        Debug.Log("SetWriteQuestion5");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 12 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[4];
        }
    }

    public void SetWriteQuestion6()
    {
        Debug.Log("SetWriteQuestion6");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 15 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[5];
        }
    }

    public void SetWriteQuestion7()
    {
        Debug.Log("SetWriteQuestion7");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 18 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[6];
        }


    }

    public void SetWriteQuestion8()
    {
        Debug.Log("SetWriteQuestion8");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 21 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[7];
        }
    }

    public void SetWriteQuestion9()
    {
        Debug.Log("SetWriteQuestion9");

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
        if (WriteManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < WriteManager.instance.ansArray.Length; i++)
            {
                int x = 24 + i;
                WriteManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
            questionArray[0].GetComponent<Renderer>().sharedMaterial = questionMaterial[8];
        }
    }

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {

    }
}
