using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class AccruciyField : MonoBehaviour
{
    private float success = 0;
    private float all = 0;

    public void SetNumbers(float success, float all)
    {
        this.success = success;
        this.all = all;
        float accruciy = (success / all) * 100;
        GetComponent<TextMeshPro>().text = $"Accruciy: {accruciy:n2} %";
    }

    public void AddSuccess(float toAdd)
    {
        SetNumbers(this.success + toAdd, this.all);
    }
    public void AddAll(float toAdd)
    {
        SetNumbers(this.success, this.all + toAdd);
    }
}
