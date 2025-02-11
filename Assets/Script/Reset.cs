using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    //private List<Vector3> positions;
    //public GameObject[] GOArray; //放所有game object
    //public GameObject[] ansArray; //存放"Ans"Array
    //public AnsPlatform platform; // 抓取Ans腳本
    //private CheckBut checkBut; //抓checkbut
    //private Canvas canvas;
    //private WordsControl wordsControl;

    //private ManoGestureContinuous grab;
    
    private ManoGestureContinuous hand;

    [SerializeField]
    private Material[] arCubeMaterial;

    private string handTag = "Player";
    private Renderer cubeRenderer;

    void Start()
    {
        //positions = new List<Vector3>(); // create new empty list
        //checkBut = FindObjectOfType<CheckBut>();
        //wordsControl = FindObjectOfType<WordsControl>();

        //ansArray = GameObject.FindGameObjectsWithTag("Ans");
        //GOArray = GameObject.FindGameObjectsWithTag("GameObject");
        Initialize();
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Initialize()
    {
        //grab = ManoGestureContinuous.CLOSED_HAND_GESTURE;
        hand = ManoGestureContinuous.OPEN_HAND_GESTURE;

        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
        cubeRenderer.material = arCubeMaterial[0];

        //if (GOArray.Length != 0)
        //{
        //    foreach (GameObject go in GOArray)
        //    {
        //        positions.Add(go.transform.position);
        //    }

        //}
    }

    /// <param name="other">The collider that stays</param>
    private void OnTriggerStay(Collider other)
    {
        MoveWhenGrab(other);
    }

    private void MoveWhenGrab(Collider other)
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == hand) //grab
        {
            //for (int i = 0; i < GOArray.Length; i++)
            //{
            //    // 將物體移動到原本位置
            //    GOArray[i].transform.position = positions[i];
            //    wordsControl = GOArray[i].GetComponent<WordsControl>();
            //    wordsControl.WordisPlaced = false;
            //}

            //for (int i = 0; i < ansArray.Length; i++)
            //{
            //    platform = ansArray[i].GetComponent<AnsPlatform>();
            //    platform.isPlaced = false;
            //}

            //checkBut.userSelection.Clear();
            //canvas.gameObject.SetActive(false);


            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);

            //// 方法2：一次性打印整?列表?容
            //string listContent = string.Join(", ", checkBut.userSelection);
            //Debug.Log("List contents: " + listContent);

        }
    }

    /// <param name="other">The collider that enters</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == handTag)
        {
            cubeRenderer.sharedMaterial = arCubeMaterial[1];
        }
    }

    /// <param name="other">The collider that exits</param>
    private void OnTriggerExit(Collider other)
    {
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
    }
}