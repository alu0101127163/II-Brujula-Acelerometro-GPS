using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour
{

		public bool isFlat = true;
		private Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
    	rigid = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {

    	Vector3 tilt = Input.acceleration;

    	if(isFlat)
    		tilt = Quaternion.Euler(90,0,0) * tilt;

    	rigid.AddForce(tilt);        
    }
}
