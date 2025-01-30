using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //offset kamera ile takip edilecek hedefin arasindaki mesafe
    //Ornegin top ile kamera arasindaki mesafe
    private void LateUpdate()
    {
        if (target != null)
        {
            //Bu kod sayesinde top gittikce ekran da gider
            transform.position = target.position + offset; 
        }
    }
}
