using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballRigidBody;
    [SerializeField] private float speed = 8f;

    private bool hasLaunched = false;


    // Update is called once per frame
    void Update()
    {
        if (!hasLaunched && Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
    }

    private void Launch()
    {
        ballRigidBody.linearVelocity = new Vector2(1,1).normalized * speed;
        hasLaunched = true;
    }
}
