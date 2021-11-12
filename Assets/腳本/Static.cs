using UnityEngine;

public class Static : MonoBehaviour
{
    [Header("��v���`��")]
    public int _cameraCount;
    [Header("2D���O�j�p")]
    public Vector2 _gravity;
    [Header("��P�v")]
    public float _PI;
    [Header("�O�_��J���N��")]
    public bool _pressKey;
    [Header("�C���g�L�ɶ�")]
    public float _gamingTime;
    [Range(0f, 1f)]
    public float _timeScale = 0.5f;
    [Header("�h�p���I")]
    public float _origin = 9.999f;
    public float _final;
    [Header("���I�Z��")]
    public Vector3 _dot1 = new Vector3(1, 1, 1);
    public Vector3 _dot2 = new Vector3(22, 22, 22);
    public float _distance;
    [Header("�O�_���USpace��")]
    public bool _pressSpace = false;

    void Start()
    {
        Physics2D.gravity = new Vector2(0, -20);
        Time.timeScale = _timeScale;

        _cameraCount = Camera.allCamerasCount;
        _gravity = Physics2D.gravity;
        _PI = Mathf.PI;
    }

    void Update()
    {
        Time.timeScale = _timeScale;

        _pressKey = Input.anyKey;
        _gamingTime = Time.realtimeSinceStartup;

        _final = Mathf.FloorToInt(_origin);

        _distance = Vector3.Distance(_dot1, _dot2);

        if (Input.GetKey(KeyCode.Space)) { _pressSpace = true; }
        else { _pressSpace = false; }
    }

    public void Click() 
    {
        Application.OpenURL("https://unity.com/");
    }
}
