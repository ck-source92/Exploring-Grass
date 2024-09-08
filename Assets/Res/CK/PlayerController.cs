using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CapsuleCollider cap;

    public bool MovePlayer = false;
    void Awake()
    {
        cap = GetComponent<CapsuleCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        // player interaction with grass
        Shader.SetGlobalVector("_Player", transform.position + Vector3.up * cap.radius);
        
        if(MovePlayer)
            Movement();
    }

    void Movement()
    {
        // player movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        transform.position += move * Time.deltaTime * 5f;
    }
}
