using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour {

    public Rigidbody2D rgb;
    public GameObject feet;

    public LayerMask layerMask;
    Animator anim;
    private float points = 0f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rgb = GetComponent<Rigidbody2D>();

        anim.SetBool("InFloor", true);
    }
	
	// Update is called once per frame
	void Update () {
        points += Time.deltaTime;

        if (points < 1f)
        {
            GameController.instance.score.text = "0";
        }
        else
        {
            GameController.instance.score.text = "" + (points.ToString("#"));
        }

        RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layerMask);
        if (raycast.collider != null)
        {
            anim.SetBool("InFloor", true);
        }
        else
        {
            if (rgb.velocity.y >= -1)
            {
                anim.SetBool("InFloor", false);
            }
            else if (rgb.velocity.y < -1)
            {
                anim.SetBool("InFloor", true);
            }
        }

        
    }
    
    public void Fly()
    {
        Debug.Log("Holi");
        rgb.AddForce(Vector2.up * 250f);
        anim.SetBool("InFloor", false);
    }
}
