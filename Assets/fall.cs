using UnityEngine;

public class fall : MonoBehaviour
{
    private int timer = 3;
    public Rigidbody er;

   private void Update()
    {
            if (Time.time > timer)
            er.useGravity = true;
    }
}
