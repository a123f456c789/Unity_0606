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
    #endregion

    # region 方法
    /// <summary>
    /// 
    /// </summary>
    private void Jump()
    {
        bool key = Input.GetKey(KeyCode.UpArrow);
        ani.SetBool("跳躍", key);
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
        bool Key= Input.GetKey(KeyCode.DownArrow);
        ani.SetBool("滑行", Key);
    }

    #endregion
    #region 事件
    private void Start()
    {
        Hit();
        Test();
       

    }
    private void Update()
    {
        Jump();
        Slide();
    }
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
 
    }
        #endregion

        //
    
