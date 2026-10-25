
using UnityEngine;

public class AircraftCollision : MonoBehaviour
{
    private bool hasCollided = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (hasCollided)
            return;

        hasCollided = true;

        Debug.Log("飛行器發生碰撞！");
        Debug.Log("碰撞物件：" + collision.gameObject.name);
    }
}
