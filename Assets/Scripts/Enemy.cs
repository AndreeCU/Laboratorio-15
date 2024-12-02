using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody2D _componentRigidbody2D;
    public float speedY;
    public GameManangerControl gameMananger;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gameMananger.UpdateScore(100);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void SetGameMananger(GameManangerControl gm)
    {
        gameMananger = gm;
    }
}
