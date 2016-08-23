using UnityEngine;
using System.Collections;

public class circleController : MonoBehaviour
{
    //半径
    public float Radiu;//半径
    public GameObject CirclePrefab;//每一段弧的预设体
    public int NumOfArc;//满圆弧的数量

    // Use this for initialization
	void Start ()
	{
        //1
	    Radiu /= 100.0f;
	    GameObject circle = Instantiate(CirclePrefab, transform) as GameObject;
        Vector2 pos = Vector2.zero;
	    Vector2 nor = new Vector2(-1.0f, 0.0f);
	    pos = nor*Radiu;
	    circle.transform.localPosition = pos;

        //2
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-45.0f, Vector3.forward);
        nor = new Vector2(-1.0f, 1.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;

        //4
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-90.0f, Vector3.forward);
        nor = new Vector2(0.0f, 1.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;

        //5
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-135.0f, Vector3.forward);
        nor = new Vector2(1.0f, 1.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;

        //6
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-180.0f, Vector3.forward);
        nor = new Vector2(1.0f, 0.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;

        //7
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-225.0f, Vector3.forward);
        nor = new Vector2(1.0f, -1.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;

        //8
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-270.0f, Vector3.forward);
        nor = new Vector2(0.0f, -1.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;

        //3
        circle = Instantiate(CirclePrefab, transform) as GameObject;
        circle.transform.localRotation = Quaternion.AngleAxis(-315.0f, Vector3.forward);
        nor = new Vector2(-1.0f, -1.0f).normalized;
        pos = nor * Radiu;
        circle.transform.localPosition = pos;
	}
	
	// Update is called once per frame
	void Update () {
	    
    }
}
