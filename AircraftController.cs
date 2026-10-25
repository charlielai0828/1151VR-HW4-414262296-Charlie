
using UnityEngine;

public class AircraftController : MonoBehaviour
{
    [Header("飛行設定")]
    public float forwardSpeed = 8f;
    public float horizontalSpeed = 5f;
    public float verticalSpeed = 5f;

    [Header("移動範圍")]
    public float horizontalLimit = 8f;
    public float verticalLimit = 5f;

    void Update()
    {
        // 持續向世界座標的 Z 正方向飛行
        transform.position +=
            Vector3.forward * forwardSpeed * Time.deltaTime;

        // 讀取鍵盤輸入
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 左右、上下移動
        Vector3 movement = new Vector3(
            horizontal * horizontalSpeed,
            vertical * verticalSpeed,
            0f
        ) * Time.deltaTime;

        transform.position += movement;

        // 限制飛行範圍
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -horizontalLimit, horizontalLimit);
        pos.y = Mathf.Clamp(pos.y, -verticalLimit, verticalLimit);
        transform.position = pos;
    }
}
