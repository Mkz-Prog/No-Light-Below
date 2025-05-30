using UnityEngine;

public class RotateArrow : MonoBehaviour
{
    float rotateSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GetComponent<GameObject>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
        }
    }
}
