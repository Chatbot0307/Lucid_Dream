using UnityEngine;
using DG.Tweening;

public class GravityChanger : MonoBehaviour
{
    public Transform playerRotation;
    public PlayerMovement playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && playerMovement.isCeiling == false)
        {
            playerRotation.transform.DORotate(new Vector3(0f, playerRotation.rotation.y, 180f), 0.5f).SetEase(Ease.InOutBack);
            playerMovement.gravity *= -1;
            playerMovement.isCeiling = true;
        }
        else
        {
            playerRotation.transform.DORotate(new Vector3(playerRotation.rotation.x, playerRotation.rotation.y, 0f), 0.5f).SetEase(Ease.InOutBack);
            playerMovement.gravity *= -1;
            playerMovement.isCeiling = false;
        }
    }
}