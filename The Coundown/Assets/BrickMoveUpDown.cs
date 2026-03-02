using UnityEngine;

public class BrickMoveUpDown : MonoBehaviour
{
    public float amplitude = 1.5f;  // how far up/down
    public float speed = 2f;        // how fast

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(startPos.x, startPos.y + yOffset, startPos.z);
    }
}
