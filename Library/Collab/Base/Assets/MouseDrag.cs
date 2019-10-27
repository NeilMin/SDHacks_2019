using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
        Vector3 ObjPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = ObjPosition;
        rb.isKinematic = false;
    }

    private void OnMouseUp()
    {
        //rb.isKinematic = true;
    }
}
