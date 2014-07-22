using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLift.UserInfo.Model
{
    public class UserDTO
    {
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        //用户名
        private string userName;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        //密码
        private string userPwd;
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }

        //注册时间
        private DateTime createTime;
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        //最近登录时间
        private DateTime lastTime;
        /// <summary>
        /// 最近登录时间
        /// </summary>
        public DateTime LastTime
        {
            get { return lastTime; }
            set { lastTime = value; }
        }

        //邮箱
        private string email;
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //地址
        private string address;
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        //身份证号
        private string cardID;
        /// <summary>
        /// 身份证号
        /// </summary>
        public string CardID
        {
            get { return cardID; }
            set { cardID = value; }
        }

        //电话
        private string callNumber;
        /// <summary>
        /// 电话
        /// </summary>
        public string CallNumber
        {
            get { return callNumber; }
            set { callNumber = value; }
        }

        //性别
        private bool sex;
        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        //生日
        private string birthday;
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        //好友
        private string frends;
        /// <summary>
        /// 好友
        /// </summary>
        public string Frends
        {
            get { return frends; }
            set { frends = value; }
        }

        //标签
        private string userMark;
        /// <summary>
        /// 标签
        /// </summary>
        public string UserMark
        {
            get { return userMark; }
            set { userMark = value; }
        }

        //头像
        private string userImage;
        /// <summary>
        /// 头像
        /// </summary>
        public string UserImage
        {
            get { return userImage; }
            set { userImage = value; }
        }
        
        //公司
        private string company;
        /// <summary>
        /// 公司
        /// </summary>
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        //职位
        private string position;
        /// <summary>
        /// 职位
        /// </summary>
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        //角色
        private bool isAdmin;
        /// <summary>
        /// 角色
        /// </summary>
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        //用户状态
        private bool status;
        /// <summary>
        /// 用户状态
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
