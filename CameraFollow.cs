
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 offset = new Vector3(0f, 3f, -7f);

    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null)
            return;

        // 計算攝影機應該跟隨的位置
        Vector3 desiredPosition = target.position + offset;

        // 平滑移動攝影機
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        // 讓攝影機朝向飛行器
        transform.LookAt(target);
    }
}
