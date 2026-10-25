
using UnityEngine;

public class ObstaclePassTrigger : MonoBehaviour
{
    private bool aircraftInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        aircraftInside = true;
        Debug.Log("飛行器進入障礙物判定區域！");
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (aircraftInside)
        {
            Debug.Log("飛行器離開障礙物判定區域！");
            Debug.Log("成功通過障礙物！");
        }

        aircraftInside = false;
    }
}
