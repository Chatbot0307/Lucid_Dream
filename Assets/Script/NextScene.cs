using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void ClickStart()
    {
        SceneManager.LoadScene("Stage1");
    }
}
