using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    public float speedY;

    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _componentRigidbody2D.velocity = new Vector2(0, speedY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
