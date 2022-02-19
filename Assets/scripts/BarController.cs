using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public BarCondition CurrentCondition = default;
    public RectTransform target;
    public float TimeSpan;
    [SerializeField] private float _radius;
    public float normarizedPosition = 0;
    private float _offset = 0.25f;


    // Start is called before the first frame update
    void Start()
    {
        CurrentCondition = BarCondition.TurnRight;
    }

    void Update()
    {
        if (CurrentCondition == BarCondition.Stop)
        {

        }
        else if (CurrentCondition == BarCondition.TurnLeft)
        {
            normarizedPosition += Time.deltaTime / TimeSpan;
            normarizedPosition = Mathf.Repeat(normarizedPosition, 1f);
            MoveBar();
        }
        else if (CurrentCondition == BarCondition.TurnRight)
        {
            normarizedPosition -= Time.deltaTime / TimeSpan;
            normarizedPosition = Mathf.Repeat(normarizedPosition, 1f);
            MoveBar();
        }
    }

    /// <summary>
    /// BarÇâÒì]ÅEà⁄ìÆÇ≥ÇπÇÈ
    /// </summary>
    private void MoveBar()
    {
        // à⁄ìÆ
        target.localPosition = new Vector3(
            _radius * Mathf.Cos((normarizedPosition + _offset) * 2 * Mathf.PI),
            _radius * Mathf.Sin((normarizedPosition + _offset) * 2 * Mathf.PI),
            0
        );

        // âÒì]
        target.rotation = Quaternion.Euler(0, 0, normarizedPosition * 360);
    }
}

public enum BarCondition
{
    Stop,
    TurnLeft,
    TurnRight
}