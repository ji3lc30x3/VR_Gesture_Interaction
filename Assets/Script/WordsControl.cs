using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsControl : MonoBehaviour
{
    public bool WordisPlaced;

    public GameObject[] ansArray; //�s��"Ans"Array
    public AnsPlatform platform; // ���Ans�}��

    private ManoGestureContinuous grab;

    //[SerializeField]
    //private Material[] arCubeMaterial;

    private Renderer cubeRenderer;

    public int x;
    public GameObject[] cubeArray; //�s��"Ans"Array

    private string handTag = "Player";

    private int checkpart;

    private Outline outline;

    void Start()
    {
        // ���Ҧ����Ҭ� "Ans" �����x
        ansArray = GameObject.FindGameObjectsWithTag("Ans");
        cubeArray = GameObject.FindGameObjectsWithTag("GameObject");
        //�����GetComponent�]���b���PGameObject�U
        // checkBut = FindObjectOfType<CheckBut>();

        // ?�� Outline ?��
        outline = GetComponent<Outline>();
        outline.enabled = false; // ��l??�T�� Outline

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
                // ���Ҧ����Ҭ� "Platform" �����x
                if (ansArray.Length != 0)
                {
                    for (int i = 0; i < ansArray.Length; i++)
                    {
                       // ����P�I�������x�����p�� Platform �}��
                       platform = ansArray[i].GetComponent<AnsPlatform>();

                       if (platform.isPlaced == false )
                       {
                        // �N���鲾�ʨ쥭�x�W
                        transform.position = ansArray[i].transform.position + new Vector3(0, (float)0.2, 0);
                        // �аO����w�Q��m�b���x�W
                        platform.isPlaced = true;
                        WordisPlaced = true;
                        string choseAns = gameObject.name;//get name
                        Debug.Log("WordsControl_choseAns"+choseAns);

                        // ?�d�C���O�_�w�s�b
                        if (!CheckBut.instance.userSelection.Contains(choseAns))
                        {
                            CheckBut.instance.userSelection.Add(choseAns); // �K�[��C��
                            Debug.Log("WordsControl_Adding_choseAns");

                            string listContent = string.Join(", ", CheckBut.instance.userSelection);
                            Debug.Log("WordsControl contents: " + listContent);
                        }

                        // ��k2�G�@���ʥ��L��?�C��?�e
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