using UnityEngine;
using System.Collections;

public class CameraNearOrFar : MonoBehaviour
{

    public float CameraSpeed;
    public float MinCameraOrthographicSize;
    public float MaxameraOrthographicSize;
    public Camera CurCamera;
    public Transform EnemyTransform;
    public Transform RoleTransform;

    // Use this for initialization
    void Awake ()
	{
	    CameraSpeed = 2.0f;
        MaxameraOrthographicSize = 30.0f;
        MinCameraOrthographicSize = 5.0f;
        CurCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButton(0))
	    {
            //Camera.current.orthographicSize = Mathf.Lerp(Camera.current.orthographicSize, MinCameraOrthographicSize, Time.deltaTime* CameraSpeed);
            CurCamera.orthographicSize -= CameraSpeed*Time.deltaTime;
            EnemyTransform.position = new Vector3(EnemyTransform.position.x, EnemyTransform.position.y- CameraSpeed * Time.deltaTime, EnemyTransform.position.z);
            RoleTransform.position = new Vector3(RoleTransform.position.x, RoleTransform.position.y + CameraSpeed * Time.deltaTime, RoleTransform.position.z);


        }
        else if(Input.GetMouseButton(1))
	    {
            //Camera.current.orthographicSize = Mathf.Lerp(Camera.current.orthographicSize, MaxameraOrthographicSize, Time.deltaTime * CameraSpeed);
            CurCamera.orthographicSize += CameraSpeed * Time.deltaTime;
            EnemyTransform.position = new Vector3(EnemyTransform.position.x, EnemyTransform.position.y + CameraSpeed * Time.deltaTime, EnemyTransform.position.z);
            RoleTransform.position = new Vector3(RoleTransform.position.x, RoleTransform.position.y - CameraSpeed * Time.deltaTime, RoleTransform.position.z);
        }
	}
}
