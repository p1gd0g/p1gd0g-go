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
    public Image _flower = null;

    DateTime _dateTime = new DateTime();

    // Start is called before the first frame update
    void Start()
    {
        _dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        _dateTime = _dateTime.AddSeconds(1638207420).ToLocalTime();

        _btn.onClick.AddListener(() =>
        {

            var mousePos = Input.mousePosition;
            var x = mousePos.x - Screen.width / 2f;
            var y = mousePos.y - Screen.height / 2f;

            var flower = Instantiate(_flower, this.transform);
            flower.transform.localPosition = new Vector3(x, y, 0);

            DOTween.Sequence().AppendInterval(0.5f).Append(flower.DOFade(0, 0.5f)).AppendInterval(0.5f).AppendCallback(
                () =>
                {
                    Debug.Log("Destroy");
                    Destroy(flower.gameObject);
                }
            );

        });
    }

    // Update is called once per frame
    void Update()
    {
        var ts = DateTime.Now.Subtract(_dateTime);
        _text.text = string.Format("{0:%d} d, {0:%h} h, {0:%m} m, {0:%s} s", ts);
    }
    void OnMouseDown()
    {
        Debug.Log("The Button is pressed" + this.name);
    }
}
