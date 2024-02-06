using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
public float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    float hitFactor(Vector2 ballPos, Vector2 racketPos,float racketWidth){
    	return (ballPos.x - racketPos.x/racketWidth);
    }
    
    void OnCollisionEnter2D(Collision2D col){
    	if(col.gameObject.name == "racket"){
    		float x=hitFactor(transform.position,col.transform.position,col.collider.bounds.size.x);
    		Vector2 dir = new Vector2(x,1).normalized;
    		GetComponent<Rigidbody2D>().velocity = dir *(speed *1.2f);
    	}
    }
}
