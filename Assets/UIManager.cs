using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject player;

    public void InteractWithPlayer()
    {
        mainCamera.GetComponent<CinemachineBrain>().enabled = true;
        if(player != null)
        {
            player.SetActive(true);
            player.GetComponent<PlayerController>().MovePlayer = true;  
        }
    }
}
