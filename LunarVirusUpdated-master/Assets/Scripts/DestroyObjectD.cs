using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectD : MonoBehaviour
{
    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}