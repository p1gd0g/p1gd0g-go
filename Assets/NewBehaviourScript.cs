using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;


public class NewBehaviourScript : MonoBehaviour
{
    public Text _text = null;
    public Image _img = null;
    public Button _btn = null;

    DateTime _dateTime = new DateTime();

    // Start is called before the first frame update
    void Start()
    {
        _dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        _dateTime = _dateTime.AddSeconds(1638207420).ToLocalTime();
    }

    // Update is called once per frame
    void Update()
    {
        var ts = DateTime.Now.Subtract(_dateTime);
        _text.text = string.Format("{0:%d} d, {0:%h} h, {0:%s} s", ts);
    }
}
