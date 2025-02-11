using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Test;
    public int part;
    public int Level;

    public List<string> correctAnswer = new List<string>();

    public bool openHand;

    public GameObject EventSystem;
    public GameObject ManomotionManagerInScene;
    public GameObject ARSessionOrigin;
    public GameObject ARSessionOrigin2;
    public GameObject ARSession;
    public GameObject ARDefaultPlane;
    public GameObject skybox;

    //�򥻳]�m
    private void Awake()
    {
        if (Instance == null) //�гy����A�Sreference�����H
        {
            Instance = this; 
            DontDestroyOnLoad(gameObject);
            InitializeObjects();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�l�ܤⳡ�ʧ@�M���d����
    private void Start()
    {
        Test = 0;
        part = 1;
        ManomotionManager.OnManoMotionFrameProcessed += HandleManoMotionFrameUpdated;
    }

    
    void HandleManoMotionFrameUpdated()
    {
        GestureInfo gesture = ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info;
        TrackingInfo tracking = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;
        Warning warning = ManomotionManager.Instance.Hand_infos[0].hand_info.warning;

        changeHandModel(gesture, warning);

    }
    void changeHandModel(GestureInfo gesture, Warning warning)
    {
        if (warning != Warning.WARNING_HAND_NOT_FOUND)
        {
            switch (gesture.mano_gesture_continuous)
            {
                case ManoGestureContinuous.OPEN_HAND_GESTURE:
                    openHand = true;
                    break;
                case ManoGestureContinuous.CLOSED_HAND_GESTURE:
                    openHand = false;
                    break;
                default:
                    break;
            }
        }
    }

    //�O�d����
    private void InitializeObjects()
    {
        DontDestroyOnLoad(EventSystem);
        DontDestroyOnLoad(ManomotionManagerInScene);
        DontDestroyOnLoad(ARSessionOrigin);
        DontDestroyOnLoad(ARSessionOrigin2);
        DontDestroyOnLoad(ARSession);
        DontDestroyOnLoad(ARDefaultPlane);
        DontDestroyOnLoad(skybox);
    }

    private void Update()
    {

    }

    public void clearScene()
    {

    }

}
