using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;



public class player : MonoBehaviour
{
    public Text Coinamount;
    public Text coinamount;
    /*
    */
    #region 角色
    public float speed;
    public float hp;
    public float hight;
    public int coin;
    public bool dead;
    public AudioClip CMusic;
    public AudioClip HMusic;
    public AudioClip JMusic;
    public AudioClip SMusic;
    public Animator ani;
    public CapsuleCollider2D Cc2d;
    public Rigidbody2D Rig;
    public bool IsGround;
    public Image Imghp;
    private float HpMax;
    public AudioSource Aud;
    public GameObject Final;
    public Text TextTitle;
    #endregion

    # region 方法
    /// <summary>
    /// 
    /// </summary>
    private void Jump()
    {
        bool key = Input.GetKeyDown(KeyCode.UpArrow);
        ani.SetBool("跳躍", !IsGround);
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
        hp -= 1;
        Imghp.fillAmount = hp / HpMax;
        Aud.PlayOneShot(HMusic);
        if(hp <= 0)Dead();
    }
    /// <summary>
    /// 
    /// </summary>
    private void Dead()
    {
        if (dead) return;
        
        speed = 0;
        dead = true;
        
        ani.SetTrigger("死亡");
        Final.SetActive(true);
        coinamount.text = "金 幣 值 : " + coin;
        TextTitle.text = "早死早超生!!";

    }
    private void Pass()
    {
        Final.SetActive(true);
        coinamount.text = "金 幣 值 : " + coin;
        TextTitle.text = "你還是得死，哈!";
        Rig.velocity = Vector3.zero;
        speed = 0;
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
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Aud.PlayOneShot(SMusic);
        }
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
    private void EatCoin(Collider2D collision)
    {
        coin++;
        Destroy(collision.gameObject);
        Coinamount.text = "金幣:" + coin;
        Aud.PlayOneShot(CMusic);
    }


    #endregion
    #region 事件
    private void Start()
    {

        HpMax = hp;


    }
    //60fps/秒
    private void Update()
    {
        if (dead) return;
        Slide();
        if (transform.position.y <= -6) Dead();

    }
    //50fps/秒
    private void FixedUpdate()
    {
        if (dead) return;
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
        if (collision.gameObject.name == "懸空")
        { IsGround = true; }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="金幣")
        {

            EatCoin(collision);
        }
        if (collision.tag=="障礙物")
        {
            Hit();
        }
        if (collision.name == "傳送門")
        Pass();
    }

    }
        #endregion

        //
    
