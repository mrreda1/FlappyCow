using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D CowRigidBody;
    public Transform CowTransform;
    public float JumpHeight = 10;
    public LogicScript logic;
    public bool isAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || isTouchDetected()) && isAlive) {
            CowRigidBody.linearVelocity = Vector2.up * JumpHeight;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        isAlive = false;
        logic.gameOver();
    }

    // Helper function to detect touch input
    private bool isTouchDetected() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began) {
                return true;
            }
        }
        return false;
    }


}
