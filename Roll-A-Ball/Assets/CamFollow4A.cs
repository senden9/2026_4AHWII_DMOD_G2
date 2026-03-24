using UnityEngine;

public class CamFollow4A : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = cam.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        cam.position = player.position + offset;
    }
}
