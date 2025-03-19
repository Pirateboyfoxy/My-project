using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Camera1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            CameraOne ();
        }
        if(Input.GetKeyDown("2"))
        {
            CameraTwo ();
        }
    }

    void CameraOne()
    {
        MainCamera.SetActive(true);
        Camera1.SetActive(false);
    }

    void CameraTwo()
    {
        MainCamera.SetActive(false);
        Camera1.SetActive(true);
    }
}
