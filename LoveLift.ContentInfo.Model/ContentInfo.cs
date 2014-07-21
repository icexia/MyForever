using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLift.ContentInfo.Model
{
    public class ContentInfo
    {
        //文章类型1、文字2、图片3、文字+图片
        private bool contentType;

        public bool ContentType
        {
            get { return contentType; }
            set { contentType = value; }
        }

        //正文
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        //图片地址
        private string imageUrl;

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        //发表人
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        //发表时间
        private DateTime createTime;

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        //评论
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        //评论时间
        private DateTime commentTime;

        public DateTime CommentTime
        {
            get { return commentTime; }
            set { commentTime = value; }
        }

        //评论人
        private string commentPepole;

        public string CommentPepole
        {
            get { return commentPepole; }
            set { commentPepole = value; }
        }

        //赞or损
        private bool isPraise;

        public bool IsPraise
        {
            get { return isPraise; }
            set { isPraise = value; }
        }

        //赞、损的人
        private string praisePepole;

        public string PraisePepole
        {
            get { return praisePepole; }
            set { praisePepole = value; }
        }

        //赞的时间
        private DateTime praiseTime;

        public DateTime PraiseTime
        {
            get { return praiseTime; }
            set { praiseTime = value; }
        }

        //正文状态
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
