using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsControl : MonoBehaviour
{
    public bool WordisPlaced;

    public GameObject[] ansArray; //存放"Ans"Array
    public AnsPlatform platform; // 抓取Ans腳本

    private ManoGestureContinuous grab;

    //[SerializeField]
    //private Material[] arCubeMaterial;

    private Renderer cubeRenderer;

    public int x;
    public GameObject[] cubeArray; //存放"Ans"Array

    private string handTag = "Player";

    private int checkpart;

    private Outline outline;

    void Start()
    {
        // 找到所有標籤為 "Ans" 的平台
        ansArray = GameObject.FindGameObjectsWithTag("Ans");
        cubeArray = GameObject.FindGameObjectsWithTag("GameObject");
        //不能用GetComponent因為在不同GameObject下
        // checkBut = FindObjectOfType<CheckBut>();

        // ?取 Outline ?件
        outline = GetComponent<Outline>();
        outline.enabled = false; // 初始??禁用 Outline

        Initialize();

    }

    private void Initialize()
    {       
        grab = ManoGestureContinuous.CLOSED_HAND_GESTURE;

        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.enabled = true;

        checkpart = GameManager.Instance.part;

        switch (checkpart)
        {
            case 1:
                Debug.Log("wordsControl_Listening");
                ListeningManager.instance.checkLevel();
                break;
            case 2:
                Debug.Log("wordsControl_Read");
                ReadManager.instance.checkLevel();
                break;
            case 3:
                Debug.Log("wordsControl_Read");
                WriteManager.instance.checkLevel();
                break;
        }

    }

    /// <param name="other">The collider that stays</param>
    private void OnTriggerStay(Collider other)
    {
        if (WordisPlaced==false)
        {
            MoveWhenGrab(other);
        }     
    }

    private void MoveWhenGrab(Collider other)
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == grab)
        {
                // 找到所有標籤為 "Platform" 的平台
                if (ansArray.Length != 0)
                {
                    for (int i = 0; i < ansArray.Length; i++)
                    {
                       // 獲取與碰撞的平台相關聯的 Platform 腳本
                       platform = ansArray[i].GetComponent<AnsPlatform>();

                       if (platform.isPlaced == false )
                       {
                        // 將物體移動到平台上
                        transform.position = ansArray[i].transform.position + new Vector3(0, (float)0.2, 0);
                        // 標記物體已被放置在平台上
                        platform.isPlaced = true;
                        WordisPlaced = true;
                        string choseAns = gameObject.name;//get name
                        Debug.Log("WordsControl_choseAns"+choseAns);

                        // ?查列表中是否已存在
                        if (!CheckBut.instance.userSelection.Contains(choseAns))
                        {
                            CheckBut.instance.userSelection.Add(choseAns); // 添加到列表
                            Debug.Log("WordsControl_Adding_choseAns");

                            string listContent = string.Join(", ", CheckBut.instance.userSelection);
                            Debug.Log("WordsControl contents: " + listContent);
                        }

                        // 方法2：一次性打印整?列表?容
                        //string listContent = string.Join(", ", checkBut.userSelection);
                        //Debug.Log("WCList contents: " + listContent);

                        break;
                        }
                  
                    }
                }
        } 
        else
        {
            transform.parent = null;
        }
    }

    /// <param name="other">The collider that enters</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == handTag)
        {
            outline.enabled=true;

        }
    }

    /// <param name="other">The collider that exits</param>
    private void OnTriggerExit(Collider other)
    {
         outline.enabled = false;

    }
}