using UnityEngine;
using UnityEngine.UI;

public class NonStatic : MonoBehaviour
{
    [Header("��v���`�ס]Depth�^")]
    public Camera _camera;
    public float _depth;
    [Header("��v���I���C��]�H���C��^")]
    public Color _cameraColor;
    [Header("�Ϥ����C��")]
    public SpriteRenderer _image1;
    public SpriteRenderer _image2;
    public Color _spriteRenderer1;
    public Color _spriteRenderer2;
    [Header("�Ϥ�1���ਤ�פ�½��")]
    public Vector3 _angle;
    public float _angleVelocity = 6f;
    public bool _image1FlipY = false;
    [Header("2D�����m����")]
    public Rigidbody2D _rigidbody2D;
    public Vector2 _velocity = new Vector2(0f, 6f);
    public Vector2 _position;
    public int _state = 1;

    public float _deltaTime;

    void Start()
    {
        _deltaTime = Time.deltaTime;

        _depth = _camera.depth;

        _cameraColor = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 0f, 1f);
        _camera.backgroundColor = _cameraColor;

        _spriteRenderer1 = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f);
        _spriteRenderer2 = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f);
        _image1.color = _spriteRenderer1;
        _image2.color = _spriteRenderer2;

        _image1FlipY = true;
        _image1.flipY = _image1FlipY;
    }

    void Update()
    {
        _angle.z = _angleVelocity * Time.deltaTime;
        _image1.transform.Rotate(_angle.x, _angle.y, _angle.z);

        if(_rigidbody2D.position.y >= 3.7f) { _state = -1; }
        else if (_rigidbody2D.position.y <= -3.7f) { _state = 1; }

        _rigidbody2D.MovePosition(_rigidbody2D.position + _state * _velocity * Time.deltaTime);
        _position = _rigidbody2D.position;
    }
}
