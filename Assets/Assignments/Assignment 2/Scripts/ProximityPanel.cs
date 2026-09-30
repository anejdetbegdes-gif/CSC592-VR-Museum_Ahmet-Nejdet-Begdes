using UnityEngine;

public class ProximityPanel : MonoBehaviour
{
    public GameObject infoPanel;

    void Start()
    {
        infoPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        infoPanel.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        infoPanel.SetActive(false);
    }
}