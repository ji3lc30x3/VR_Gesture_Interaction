using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // 引入 System.Linq 命名空
using TMPro;
using UnityEngine.SceneManagement;

public class CheckBut : MonoBehaviour
{
    public static CheckBut instance;

    public GameObject[] ansArray; //存放"Ans"Array
    public AnsPlatform platform; // 抓取Ans腳本
    public WordsControl wordsControl;

    public List<string> userSelection = new List<string>();
    public bool compare;
    public TMP_Text text;

    // canvas that will be shown/hidden
    public Canvas canvas;
    private ManoGestureContinuous hand;

    [SerializeField]
    private Material[] arCubeMaterial;
    
    private string handTag = "Player";
    private Renderer cubeRenderer;

    private bool isGrabbing; // 新增變數，紀錄是否正在抓取 
    private bool isChecking; // 初始化檢查狀態為 false
    public string currentSceneName;

    void Start()
    {
        // 确保canvas初始被禁用
        canvas.gameObject.SetActive(false);

        wordsControl = FindObjectOfType<WordsControl>();
        currentSceneName = SceneManager.GetActiveScene().name;

        Initialize();
    }

    private void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(gameObject);
    }

    private void Initialize()
    {
        hand = ManoGestureContinuous.OPEN_HAND_GESTURE;

        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
        cubeRenderer.material = arCubeMaterial[0];

        isGrabbing = false; // 初始化抓取狀態為 false 
        isChecking = false; // 初始化檢查狀態為 false

    }

    /// <param name="other">The collider that stays</param>
    private void OnTriggerStay(Collider other)
    {
        string listContent = string.Join(", ", userSelection);
        Debug.Log("CheckBut OnTriggerStay contents: " + listContent); //got it
        MoveWhenGrab(other);
    }

    private void MoveWhenGrab(Collider other)
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == hand)
        {
            if (!isGrabbing&&!isChecking)
            {
                string listConte = string.Join(", ", userSelection);
                Debug.Log("CheckBut MoveWhenGrab 3 contents: " + listConte);

                isGrabbing = true; // 設定為抓取狀態 

                if (userSelection.Count>0)
                {
                    compare = userSelection.SequenceEqual(GameManager.Instance.correctAnswer);

                    string listCont = string.Join(", ", GameManager.Instance.correctAnswer);
                    Debug.Log("CheckBut_Correct Answer List: " + listCont);

                    foreach (var userSelect in userSelection)
                    {
                        Debug.Log("CheckBut_userSelection: " + userSelect);
                    }

                    if (compare)
                    {
                        canvas.gameObject.SetActive(true);
                        text.text = "Correct";
                        Debug.Log("Correct");

                        int tempTest = GameManager.Instance.Test;
                        Debug.Log("CheckBut tempTest" + tempTest);
                        tempTest += 1;
                        GameManager.Instance.Test = tempTest;
                        Debug.Log("tempTest"+tempTest);

                        StartCoroutine(reLoadScene());

                        if (tempTest % 3 == 0) // 如果 test 是 3 的倍數，則切換場景
                        {
                            Debug.Log("GameManager.Instance.Test" + GameManager.Instance.Test); //是0沒有錯

                            GameManager.Instance.Test = 0;

                            text.text = "You're moving to the next part.";
                            StartCoroutine(TimeChangePart());
                        }

                    }
                    else
                    {
                        canvas.gameObject.SetActive(true);
                        text.text = "Incorrect, please try again.";

                        StartCoroutine(reLoadScene());
                    }
                }
                else
                {
                    Debug.Log("CheckBut_userSelection.Count<0");
                }
            }     
        }
        else
        {
            isGrabbing = false;
        }
    }

    private IEnumerator reLoadScene()
    {
        isChecking = true; // 開始檢查，防止重複觸發
        userSelection.Clear(); //好像28加的
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(currentSceneName);
        isChecking = false; // 檢查結束，允許再次觸發
    }

    IEnumerator TimeChangePart()
    {
        isChecking = true; // 開始檢查，防止重複觸發
        int tempPart = GameManager.Instance.part;
        tempPart += 1;
        GameManager.Instance.part = tempPart;
        Debug.Log("tempPart"+ tempPart);
        
        //28
        userSelection.Clear();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(tempPart);
        isChecking = false; // 檢查結束，允許再次觸發
    }

    /// <param name="other">The collider that enters</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == handTag)
        {
            //變綠色
            cubeRenderer.sharedMaterial = arCubeMaterial[1];
        }
    }

    /// <param name="other">The collider that exits</param>
    private void OnTriggerExit(Collider other)
    {
        //原本的
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
    }
}