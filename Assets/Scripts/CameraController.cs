using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float cameraSpeed;

	void Update()
    {
		transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0f, 0f);
    }
}
