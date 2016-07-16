using UnityEngine;
using System.Collections;

public class SomeScript01 : MonoBehaviour
{
    [SerializeField] Transform _transform;
    [SerializeField] float _speed = 10f;

	// Update is called once per frame
	void Update ()
    {
        _transform.Translate(_transform.right * _speed * Time.deltaTime);	
	}
}
