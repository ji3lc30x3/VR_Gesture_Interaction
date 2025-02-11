using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollider : MonoBehaviour
{
    #region Singleton
    private static HandCollider _instance;

    public GameObject openModelPrefab; // 新模型的预制体
    public GameObject closeModelPrefab; // 新模型的预制体

    private bool getHand;
    public static HandCollider Instance
    {
        get
        {
            return _instance;
        }

        set
        {
            _instance = value;
        }
    }
    #endregion

    private TrackingInfo tracking;
    public Vector3 currentPosition;

    private void Start()
    {
        gameObject.tag = "Player";

        // 确保初始状态下只有一个Prefab启用
        openModelPrefab.SetActive(true);
        closeModelPrefab.SetActive(false);
    }

    private void Awake()
    {
            DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        tracking = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;
        currentPosition = Camera.main.ViewportToWorldPoint(new Vector3(tracking.palm_center.x, tracking.palm_center.y, tracking.depth_estimation));
        transform.position = currentPosition;

        getHand = GameManager.Instance.openHand;

        if (getHand)
        {
            openModelPrefab.SetActive(true);
            closeModelPrefab.SetActive(false);
        }
        else
        {
            openModelPrefab.SetActive(false);
            closeModelPrefab.SetActive(true);
        }
    }
}