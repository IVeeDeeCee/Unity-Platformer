using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
                     private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //Horizontal movement

        float horizontalInput = Input.GetAxis("Horizontal");
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip character on moving

        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < 0.01f)
            transform.localScale = new Vector3(-1,1,1);

        //Jumping!

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
    }
}
