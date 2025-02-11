using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // 引入 System.Linq
using UnityEngine.SceneManagement;

public class Start_But : MonoBehaviour
{
    private ManoGestureContinuous hand;

    public List<string> userSelection = new List<string>();

    [SerializeField]
    private Material[] arCubeMaterial;
 
    private string handTag = "Player";
    private Renderer cubeRenderer;

    public string getLevel;

    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        hand = ManoGestureContinuous.OPEN_HAND_GESTURE;
        cubeRenderer = GetComponent<Renderer>();

        cubeRenderer.sharedMaterial = arCubeMaterial[0];
        cubeRenderer.material = arCubeMaterial[0];
    }

    /// <param name="other">The collider that stays</param>
    private void OnTriggerStay(Collider other)
    {
        MoveWhenGrab(other);
    }

    private void MoveWhenGrab(Collider other)
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == hand)
        {
            for (int i = 0; i < 1; i++)
            {
                getLevel = userSelection[i];
                int changeLevel;
                int.TryParse(getLevel, out changeLevel);

                GameManager.Instance.Level = changeLevel;
        
                switch (changeLevel)
                {
                    case 1:
                        SceneManager.LoadScene(1);
                        changeLevel = 1;
                        
                        break;
                    case 2:
                        SceneManager.LoadScene(1);
                        changeLevel = 2;
                        break;
                    case 3:
                        SceneManager.LoadScene(1);
                        changeLevel = 3;
                        break;
                }

            }

        }
    }

    /// <param name="other">The collider that enters</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == handTag)
        {
            cubeRenderer.sharedMaterial = arCubeMaterial[1];//有到
        }
    }

    /// <param name="other">The collider that exits</param>
    private void OnTriggerExit(Collider other)
    {
        cubeRenderer.sharedMaterial = arCubeMaterial[0]; //有到
    }
}