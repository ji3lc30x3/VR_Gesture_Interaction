using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Reading : MonoBehaviour
{
    public static Reading instance;

    [SerializeField]
    public Material[] arCubeMaterial;

   // private Renderer cubeRenderer;

    public GameObject[] ansArray; //存放"Ans"Array
    //private List<string> ans = new List<string>();

    public TMP_Text question;

    void Start()
    {
        ansArray = GameObject.FindGameObjectsWithTag("GameObject");
  
        question = GetComponent<TMP_Text>();
    }

    public void SetReadingQuestion1()
    {
        Debug.Log("SetReadingQuestion1");

        List<string> correctAns = new List<string>(){"2"};
        GameManager.Instance.correctAnswer.Clear();

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "A (     ) works in a hospital.";

        Debug.Log("write ansArray Length" + ReadManager.instance.ansArray.Length);
        foreach (var cube in ReadManager.instance.ansArray)
        {
            Debug.Log("Read cubes name: " + cube.name);
        }

        for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
        {
            Debug.Log("Read for loop: " + i);
            ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[i];
        }
    }

    public void SetReadingQuestion2()
    {
        Debug.Log("SetReadingQuestion2");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "3" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "In winter, I wear a warm (     ) to stay warm.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 3 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
        }
    }

    public void SetReadingQuestion3()
    {
        Debug.Log("SetReadingQuestion3");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() {"2"};

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "We live in (     ), an island country in Asia.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 6 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
        }
    }

    public void SetReadingQuestion4()
    {
        Debug.Log("SetReadingQuestion4");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() {  "2" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "I like listening to (     ) in my free time.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 9 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];

            }
        }
    }

    public void SetReadingQuestion5()
    {
        Debug.Log("SetReadingQuestion5");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() {"1" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "We play basketball in the (     ) after school.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 12 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];

            }
        }
    }

    public void SetReadingQuestion6()
    {
        Debug.Log("SetReadingQuestion6");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "3" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "I usually (     ) for eight hours every night.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 15 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
        }
    }

    public void SetReadingQuestion7()
    {
        Debug.Log("SetReadingQuestion7");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2"};

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "I like to (     ) TV after doing my homework.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 18 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];

            }
        }


    }

    public void SetReadingQuestion8()
    {
        Debug.Log("SetReadingQuestion8");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "1" };

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "I often (     ) to school with my friends.";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 21 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];

            }
        }
    }

    public void SetReadingQuestion9()
    {
        Debug.Log("SetReadingQuestion9");

        GameManager.Instance.correctAnswer.Clear();
        List<string> correctAns = new List<string>() { "2"};

        foreach (string item in correctAns)
        {
            if (!GameManager.Instance.correctAnswer.Contains(item)) //檢查是否有重複添加
            {
                GameManager.Instance.correctAnswer.Add(item); // 添加到列表
            }
        }

        question.text = "We brush our teeth in the (     ).";

        //換material
        if (ReadManager.instance.ansArray.Length != 0)
        {
            for (int i = 0; i < ReadManager.instance.ansArray.Length; i++)
            {
                int x = 24 + i;
                ReadManager.instance.ansArray[i].GetComponent<Renderer>().sharedMaterial = arCubeMaterial[x];
            }
        }
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
