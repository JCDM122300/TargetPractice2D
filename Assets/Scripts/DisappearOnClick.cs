using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisappearOnClick : MonoBehaviour
{
    //Camera m_Camera;

    // Start is called before the first frame update
    void Start()
    {
        //m_Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOnClick();





        //var ray = new Ray2D(this.transform.position, this.);
        //Physics2D.Raycast()

        /*Mouse mouse = Mouse.current;
        if (mouse.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = mouse.position.ReadValue();
            Ray2D ray = m_Camera.
        }*/
    }

    void DestroyOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
           //Create the ray at the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if(hit.collider != null)
            {
                Target target = hit.collider.GetComponent<Target>();
                if(target != null )
                {
                    target.HitTarget();
                }
            }
        }

        
       

    }
}
