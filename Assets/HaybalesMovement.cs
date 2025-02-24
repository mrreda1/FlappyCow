using UnityEngine;

public class HaybalesMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movementSpeed = 4;
    public float deadZone = -13f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + 
        Vector3.left * movementSpeed * Time.deltaTime;
        if (transform.position.x < deadZone) {
            Debug.Log("Haybale destroyed.");
            Destroy(gameObject);
        }
    }
}