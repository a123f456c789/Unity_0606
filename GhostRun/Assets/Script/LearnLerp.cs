
using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public int a = 0;
    public int b = 10;

    
    private void Start()
    {
        float c = (Random.value);
        float r = Mathf.Lerp(a, b, c);
        print(r);

    }
    private void FixedUpdate()
    {
        float c = (Random.value);
        float r = Mathf.Lerp(a, b, c);
        print(r);
        
    }
    }
