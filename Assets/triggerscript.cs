using UnityEngine;

public class triggerscript : MonoBehaviour
{
    public GameObject[] balls;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            foreach(GameObject ball in balls)
            {
                ball.SetActive(true);
            }
        }
    }

}
