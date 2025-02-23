using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    public GameObject playerMove;

    public Transform playerRotion;

    void Start()
    {
        
    }

 
    void Update()
    {
        Debug.Log(playerMove.GetComponent<PlayerMovement>().gravity);
    }
}
