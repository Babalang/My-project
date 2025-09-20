using UnityEngine;

public class MouseBehaviorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
	public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
	
	float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed; 
	float z= Input.GetAxis("Vertical") * Time.deltaTime * speed; 
	transform.Translate(x, 0, z);
        
    }
}
