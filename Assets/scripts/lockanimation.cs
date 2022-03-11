using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class lockanimation : MonoBehaviour
{
    public bool trigger;
    public bool wait;

    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == true)
        {
            StartCoroutine("animationSequence");
            trigger = false;
        }
    }

    IEnumerator animationSequence()
    {
        transform.DOLocalMove(new Vector3(0, 150f, 0), 0.2f);
        yield return new WaitForSeconds(0.2f);
        transform.DOLocalMove(new Vector3(0, 100f, 0), 0.2f);
        yield return new WaitForSeconds(0.2f);
        transform.DOLocalMove(new Vector3(0, 600f, 0), 0.6f);
        yield return new WaitForSeconds(0.6f);
        Reset();
    }

    private void Reset()
    {
        transform.DOLocalMove(new Vector3(0f, 132.2f, 0f), 0f);
    }
}
