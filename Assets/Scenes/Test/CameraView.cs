using UnityEngine;

public class CameraView : MonoBehaviour
{
    private Camera PlayerCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerCamera = Camera.main;
        // PlayerCamera.orthographic = true;
        PlayerCamera.orthographic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
