
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float moveSpeed;
    private GameObject obj;
    private float oldPosition;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(-1 * Time.deltaTime * moveSpeed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag.Equals("Reset"))
        {
            obj.transform.localPosition = new Vector3(oldPosition, Random.Range(minY, maxY), 0);
        }
       
    }
}

