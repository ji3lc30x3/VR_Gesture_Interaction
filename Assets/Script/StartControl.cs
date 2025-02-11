using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControl : MonoBehaviour
{
    //����}�l�e����cube

    public bool WordisPlaced;
    public bool WordsPlaced;

    public GameObject[] ansArray; //�s��"Ans"Array
    public AnsPlatform platform; // ���Ans�}��

    private ManoGestureContinuous grab;
    public Start_But start_But;

    [SerializeField]
    private Material[] arCubeMaterial;

    private string handTag = "Player";
    private Renderer cubeRenderer;

    void Start()
    {
        // ���Ҧ����Ҭ� "Ans" �����x
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
            // ���Ҧ����Ҭ� "Platform" �����x
            if (ansArray.Length != 0)
            {
                for (int i = 0; i < ansArray.Length; i++)
                {
                    // ����P�I�������x�����p�� Platform �}��
                    platform = ansArray[i].GetComponent<AnsPlatform>();

                    if (platform.isPlaced == false)
                    {
                        // �N���鲾�ʨ쥭�x�W
                        transform.position = ansArray[i].transform.position + new Vector3(0, (float)0.2, 0);
                        // �аO����w�Q��m�b���x�W
                        platform.isPlaced = true;
                        WordisPlaced = true;

                        string temp=gameObject.name;
                        start_But.userSelection.Add(temp); // �K�[��C��
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