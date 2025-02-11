using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControl : MonoBehaviour
{
    //控制開始畫面的cube

    public bool WordisPlaced;
    public bool WordsPlaced;

    public GameObject[] ansArray; //存放"Ans"Array
    public AnsPlatform platform; // 抓取Ans腳本

    private ManoGestureContinuous grab;
    public Start_But start_But;

    [SerializeField]
    private Material[] arCubeMaterial;

    private string handTag = "Player";
    private Renderer cubeRenderer;

    void Start()
    {
        // 找到所有標籤為 "Ans" 的平台
        ansArray = GameObject.FindGameObjectsWithTag("Ans");
        start_But = FindObjectOfType<Start_But>();
        Initialize();

    }

    private void Initialize()
    {

        grab = ManoGestureContinuous.CLOSED_HAND_GESTURE;

        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
        cubeRenderer.material = arCubeMaterial[0];

    }

    /// <param name="other">The collider that stays</param>
    private void OnTriggerStay(Collider other)
    {
        if (WordisPlaced == false)
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

                    if (platform.isPlaced == false)
                    {
                        // 將物體移動到平台上
                        transform.position = ansArray[i].transform.position + new Vector3(0, (float)0.2, 0);
                        // 標記物體已被放置在平台上
                        platform.isPlaced = true;
                        WordisPlaced = true;

                        string temp=gameObject.name;
                        start_But.userSelection.Add(temp); // 添加到列表
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
            cubeRenderer.sharedMaterial = arCubeMaterial[1];
        }
    }

    /// <param name="other">The collider that exits</param>
    private void OnTriggerExit(Collider other)
    {
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
    }
}