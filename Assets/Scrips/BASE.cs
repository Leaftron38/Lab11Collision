using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BASE : MonoBehaviour
{
    public float VelocityX;
    public float DireccionX;
    public float VelocityY;
    public float DireccionY;
    private Rigidbody2D _body2D;
    private SpriteRenderer _renderer;
    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _body2D = GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        _body2D.velocity = new Vector2(VelocityX * DireccionX * Time.deltaTime, VelocityY * DireccionY * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bloqueos")
        {
            DireccionX = DireccionX * -1;
            if(DireccionX == -1)
            {
                _renderer.flipX = true;
            }
            else
            {
                _renderer.flipX = false;
            }
        }
        else if(collision.gameObject.tag == "BloqueosY")
        {
            DireccionY = DireccionY * -1;
            if(DireccionY == -1)
            {
                _renderer.flipY = true;
            }
            else
            {
                _renderer.flipY = false;
            }
            
        }
        
    }
}
