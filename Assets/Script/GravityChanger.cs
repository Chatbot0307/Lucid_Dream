using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    public Transform playerRotation;
    public PlayerMovement playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 180f);
            playerMovement.gravity *= -1;
        }
    }
}
