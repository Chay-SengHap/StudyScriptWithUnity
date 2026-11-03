using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f, 2.37f, -3.04f);
    public float smoothSpeed = 5f;


    void LateUpdate(){

        Vector3 targetPosition = player.position + offset;

        transform.position = Vector3.Lerp(
            transform.position ,
            targetPosition , 
            smoothSpeed * Time.deltaTime
        );

        transform.LookAt(player.position);

    }
}
