using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundPlay : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clipArray;

    private float cooldownTime = 2.0f;  // §N???¡A?¦ì?¬í
    private float lastPlayTime;

    private ManoGestureContinuous hand;

    [SerializeField]
    private Material[] arCubeMaterial;

    private string handTag = "Player";
    private Renderer cubeRenderer;

    private int test;
    private int level;

    void Start()
    {
        level = GameManager.Instance.Level;
        test = GameManager.Instance.Test;

        Initialize();

        
    }

    public void checkLevel()
    {
        switch (level)
        {
            case 1:
                Debug.Log("SoundPlay 1");
                LiteningQuestion_Level_1();
                break;
            case 2:
                Debug.Log("SoundPlay 2");
                LiteningQuestion_Level_2();
                break;
            case 3:
                Debug.Log("SoundPlay 2");
                LiteningQuestion_Level_3();
                break;
        }
    }

    public void LiteningQuestion_Level_1()
    {
        switch (test)
        {
            case 0:
                audioSource.clip = clipArray[0];
                audioSource.Play();
                break;
            case 1:
                audioSource.clip = clipArray[1];
                audioSource.Play();
                break;
            case 2:
                audioSource.clip = clipArray[2];
                audioSource.Play();
                break;
        }
    }

    public void LiteningQuestion_Level_2()
    {
        switch (test)
        {
            case 0:
                audioSource.clip = clipArray[3];
                audioSource.Play();
                break;
            case 1:
                audioSource.clip = clipArray[4];
                audioSource.Play();
                break;
            case 2:
                audioSource.clip = clipArray[5];
                audioSource.Play();
                break;
        }
    }
    public void LiteningQuestion_Level_3()
    {
        switch (test)
        {
            case 0:
                audioSource.clip = clipArray[6];
                audioSource.Play();
                break;
            case 1:
                audioSource.clip = clipArray[7];
                audioSource.Play();
                break;
            case 2:
                audioSource.clip = clipArray[8];
                audioSource.Play();
                break;
        }
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
            // ListeningManager.instance.checkLevel();
               
            if (Time.time >= lastPlayTime + cooldownTime)
            {
                lastPlayTime = Time.time;
                
                checkLevel();

                //audioSource.clip = clipArray[ts];
                //audioSource.Play();
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