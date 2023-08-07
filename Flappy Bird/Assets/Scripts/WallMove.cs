
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
        minY = 0.7f;
        maxY = 1.2f;

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(-1 * Time.deltaTime * moveSpeed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        float a = Random.Range(minY, maxY);
        obj.transform.localPosition = new Vector3(oldPosition, a, 0);
        Debug.Log("thay doi " + obj.name);
        Debug.Log("vi tri" + obj.transform.position.ToString());
    }
}

