using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private float paddleSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * paddleSpeed * Time.deltaTime);
    }
}
