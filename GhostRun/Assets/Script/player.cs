using UnityEngine;

public class player : MonoBehaviour
{
    
    /*
    */
    #region 角色
    public float speed;
    public float hp;
    public float hight;
    public int coin;
    public bool dead;
    public AudioClip CMusic;
    public AudioClip JMusic;
    public AudioClip SMusic;
    public Animator  ani;
    public CapsuleCollider2D Cc2d;
    public Rigidbody2D Rig;
    public bool IsGround;
    #endregion

    # region 方法
    /// <summary>
    /// 
    /// </summary>
    private void Jump()
    {
        bool key = Input.GetKey(KeyCode.UpArrow);
        ani.SetBool("跳躍",!IsGround);
        if (IsGround)
        {
            if (key)
            {
                IsGround = false;
                Rig.AddRelativeForce(new Vector2(0, hight));
            }
        }
       
    }
    /// <summary>
    /// 
    /// </summary>
    private void Hit()
    {
        print("碰撞");
    }
    /// <summary>
    /// 
    /// </summary>
    private void Dead()
    {

    }
    /// <summary>

    /// 
    /// </summary>
    private void Coin()
    {

    }
    /// <summary>
    /// 
    /// </summary>
    private void Slide()
    {
        bool Key = Input.GetKey(KeyCode.DownArrow);
        ani.SetBool("滑行", Key);
        if (Key)
        {
            Cc2d.offset = new Vector2(0.1519775f, -1.5f);
            Cc2d.size = new Vector2(4.096518f, 3.0f);
        }
        else
        {
            Cc2d.offset = new Vector2(0.1519775f, -0.4559404f);
            Cc2d.size = new Vector2(4.096518f, 6.023365f);
        }
        
    }
    private void Move()
    {
        if (Rig.velocity.magnitude < 6) 
        {
            Rig.AddForce(new Vector2(speed, 0));
        }
       
    }

    #endregion
    #region 事件
    private void Start()
    {
        Hit();
        Test();
       

    }
    //60fps/秒
    private void Update()
    {
       
        Slide();
       
    }
    //50fps/秒
    private void FixedUpdate()
    {
        Jump();
        Move();
    }
    /// <summary>
    /// 

    public void Test()
    {
        print("測試方法");
    }
    public void SkillFrie()
    {
        print("施放火焰");
        print("播放音效");

    }
    public void SkillWater()
    {
        print("施放水流");
        print("播放音效");
    }  
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "地板")
        {
            IsGround = true;
        }
    }

}
        #endregion

        //
    
