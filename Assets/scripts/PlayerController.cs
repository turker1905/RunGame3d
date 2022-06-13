using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float _moveSpeed,_speed;
    float _sinir;

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime, 0,_speed*Time.deltaTime));
        _sinir = transform.position.x;
        _sinir = Mathf.Clamp(_sinir, -4.4f, +4.4f);
        transform.position = new Vector3(_sinir, transform.position.y, transform.position.z);

    }





}
