using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float Speed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float AxisX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float Axisy = 0;
        float Axisz = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        transform.Translate(AxisX, Axisy, Axisz);
    }
}
