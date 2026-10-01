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
        if (other.CompareTag("Player"))
            infoPanel.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            infoPanel.SetActive(false);
    }
}