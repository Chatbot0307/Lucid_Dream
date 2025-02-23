using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCount : MonoBehaviour
{
    public int countPortal;

    private void Update()
    {
        if(countPortal == 16)
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
