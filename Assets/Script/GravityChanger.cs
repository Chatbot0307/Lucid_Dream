using UnityEngine;
using DG.Tweening;

public class GravityChanger : MonoBehaviour
{
    public Transform playerRotation;
    public PlayerMovement playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerRotation.rotation = 
            playerMovement.gravity *= -1;
        }
    }
}
