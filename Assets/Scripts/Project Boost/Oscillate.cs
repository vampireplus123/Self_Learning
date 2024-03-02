using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    Vector3 startingPos;
    public Vector3 movementVector;
    [SerializeField] [Range(0,1)] float movementFactor;
    public float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon){return;}
        float cycles = Time.time/period; //chu kỳ tăng dần theo thời gian
        const float taunt = Mathf.PI*2; // giá trị biên độ không đổi 6.28 

        float sineWave = Mathf.Sin(taunt*cycles); // sóng Sin trả về -1 đến 1
        movementFactor = (sineWave + 1)/2f; // tính toán lại để sóng Sin trả ra từ 0 đén 1

        Vector3 offset = movementVector*movementFactor;
        transform.position =startingPos + offset;
    }
}
