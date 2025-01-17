﻿using System.Collections;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [SerializeField] private Vector3 _newScale;
    [SerializeField] private float _delay;

    private Vector3 _defaltScale;

    private void Start()
    {
        _defaltScale = transform.localScale;
    }

    public void OnDown()
    {
        if (transform.localScale == _defaltScale)
        {
            transform.localScale = _newScale;
            StartCoroutine(ReturnScale());
        }
    }

    private IEnumerator ReturnScale()
    {
        yield return new WaitForSeconds(_delay);
        transform.localScale = _defaltScale;
        transform.position += new Vector3(0, 0.5f);
    }
}
