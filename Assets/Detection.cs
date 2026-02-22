using UnityEngine;

public class Detection : MonoBehaviour
{
    private int hit = 0;
    private void OnCollisionEnter(Collision collision)
        private Rigidbody rb;
        private move
    {
       
        hit = hit+1;

        //Debug.Log("Player Collided");
        //Debug.Log(collision.gameObject.name);

       if(collision.gameObject.CompareTag("Obstacles"));
        {
            MeshRenderer meshRenderer = collision.gameObject.GetComponent<MeshRenderer>();
            Material material = meshRenderer.material;
            material.color = Color.red;
        }
        Debug.Log(" the player has collided " + hit + " times ");

       
        
 }
}