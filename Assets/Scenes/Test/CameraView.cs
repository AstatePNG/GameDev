using UnityEngine;

public class CameraView : MonoBehaviour
{
    private Camera PlayerCamera;
    private bool orthographicView = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerCamera = Camera.main;
        PlayerCamera.orthographic = orthographicView;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
