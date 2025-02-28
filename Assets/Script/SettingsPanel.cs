using UnityEngine;
using DG.Tweening;

public class SettingsPanel : MonoBehaviour
{
    public RectTransform panel;
    private Vector2 visiblePosition;
    private Vector2 closePosition;

    private void Start()
    {
        visiblePosition = panel.transform.position;
        closePosition = panel.transform.position;
    }

    public void ShowPanel()
    {
        panel.DOAnchorPos(Vector2.zero, 1.0f).SetEase(Ease.OutBounce);
    }

    public void ClosePanel()
    {
        panel.DOAnchorPos(new Vector2(-4170, 0), 0.6f).SetEase(Ease.OutQuint);
    }
}
