using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset;
    Vector3 newPos;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}
