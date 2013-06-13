using UnityEngine;
using System.Collections;

public class move_camera : MonoBehaviour {
	
	public float walkSpeed = 2.0f;
	public float currentAxisX = 0f;
	public float currentAxisY = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//左右に傾けたときの重力ベクトルの値の差を左右の移動とする
		//h = Mathf.Clamp(Input.gyro.gravity.y * gyroScale, -1.0, 1.0);
		//手前・奥に傾けたときの重力ベクトルの値の差を手前・奥の移動とする
		//v = Mathf.Clamp(-1 * (Input.gyro.gravity.x - 0.6) * gyroScale, -1.0, 1.0);
        
		//transform.rotation = Quaternion.AngleAxis(nx, new Vector3(0, 1, 0)) * Quaternion.AngleAxis(ny, new Vector3(1, 0, 0));
		
		
		currentAxisX = Input.acceleration.x;
		currentAxisY = Input.acceleration.y;
		float anglex = 45 + currentAxisX * 90 * 2;
		float angley = currentAxisY * 75 + 45;
		transform.rotation = Quaternion.AngleAxis(anglex, new Vector3(0, 1, 0)) * Quaternion.AngleAxis(angley, new Vector3(1, 0, 0));
			
		Vector3 velocity = new Vector3(0, 0, 1);
		// velocityをローカル座標系からグローバル座標系へ変換
		velocity = transform.TransformDirection(velocity);
		velocity *= walkSpeed;
		
		if (velocity.x > 20000)
			velocity.x = 20000;
		if (velocity.z > 20000)
			velocity.z = 20000;
		if (velocity.y < 0)
			velocity.y = 0;
		
    	transform.Translate(velocity);
		
		//move(velocity * Time.deltaTime);
	}
}
