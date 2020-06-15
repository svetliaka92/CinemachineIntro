using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private GameObject lineCanvas;

    private void Start()
    {
        lineCanvas.SetActive(false);
    }

    public void ShowText(bool flag = true)
    {
        lineCanvas.SetActive(flag);
    }
}