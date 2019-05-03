using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3f;

        // Auto typecast
        heightDetail = height;

        // Direct typecast
        height = (int)heightDetail;

        //조건문 if문
        bool isBoy = true;

        if(isBoy == true)
        {
            Debug.Log("나는 남자다");
        }
        else
        {
            Debug.Log("나는 여자다");
        }

        isBoy = false;

        if(isBoy == true)
        {
            Debug.Log("나는 남자다");
        }
        else
        {
            Debug.Log("나는 여자다");
        }
            
    }


}
